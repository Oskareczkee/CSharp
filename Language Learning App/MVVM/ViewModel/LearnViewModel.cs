using Language_Learning_App.Core;
using Language_Learning_App.DB;
using Language_Learning_App.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Learning_App.MVVM.ViewModel
{
    public class LearnViewModel : ObservableObject
    {
        private string _WordToTranslate = string.Empty;
        private string _Translation = string.Empty;
        private string _UserTranslation = string.Empty;
        private string _Placeholder = string.Empty;
        private bool _ShowError = false;

        private Translation ActualTranslation { get; set; }
        private User User { get; set; }
        private Session Session { get; set; }
        private readonly Context Context = new Context();

        public RelayCommand CheckTranslationCommand { get; set; }
        public RelayCommand GetNextWordCommand { get; set; }

        public string WordToTranslate
        {
            get { return _WordToTranslate; }
            set { _WordToTranslate = value; OnPropertyChanged(); }
        }

        public string Translation
        {
            get { return _Translation; }
            set { _Translation = value; OnPropertyChanged(); }
        }

        public string UserTranslation
        {
            get { return _UserTranslation; }
            set { _UserTranslation = value; OnPropertyChanged("UserTranslation"); }
        }

        public string Placeholder
        {
            get { return _Placeholder; }
            set { _Placeholder = value; OnPropertyChanged(); }
        }

        public bool ShowError
        {
            get { return _ShowError; }
            set { _ShowError = value; OnPropertyChanged(); }
        }


        public LearnViewModel()
        {
            //Since we don't have interface to change user, for now we take the first entity
            User = Context.Users.First();
            Session = GetOrCreateUserSession(User);

            //Get first random word to translate
            GetNextWord();

            CheckTranslationCommand = new RelayCommand(o =>
            {
                if (ActualTranslation?.ID < 0)
                    return;

                if (!UserTranslation.Equals(Translation, StringComparison.OrdinalIgnoreCase))
                {
                    ShowError = true;
                    AddUserFail();

                    CheckSessionTime();
                    Session.Fails++;
                    UpdateSession();
                }
                else
                {
                    AddUserSuccess();
                    MarkCompleted();

                    CheckSessionTime();
                    Session.Successes++;
                    Session.WordsTranslated++;
                    UpdateSession();

                    ShowError = false;
                    GetNextWord();
                    ClearUserInput();
                }
            });

            GetNextWordCommand = new RelayCommand(o =>
            {
                //make sure to hide error textblock if previous user inputs was invalid
                ShowError = false;
                GetNextWord();
                ClearUserInput();
            });
        }

        //Ads +1 to success count and saves entity to the database
        private void AddUserSuccess()
        {
            User.SuccessCount++;
            Context.Users.Update(User);
            Context.SaveChanges();
        }
        //Ads +1 to fail count and saves entity to the database
        private void AddUserFail()
        {
            User.FailCount++;
            Context.Users.Update(User);
            Context.SaveChanges();
        }

        //marks actual translation as completed
        private void MarkCompleted()
        {
            //If ID is -1, then this translation is some kind of message to the user
            if (ActualTranslation.ID < 0)
                return;

            ActualTranslation.Completed = true;
            Context.Translations.Update(ActualTranslation);
            Context.SaveChanges();
        }

        /*In normal program this should be done via dependency injection pattern using ISession interface*/
        private Session GetOrCreateUserSession(User User)
        {
            Session? session = Context.Sessions.Where(s => s.UserID == User.ID && s.Date.DayOfYear == DateTime.Now.DayOfYear).FirstOrDefault() ?? null;
            //if there is no session for that day, create new session and add it to the database
            if(session == null)
            {
                session = new Session {User = User};
                Context.Sessions.Add(session);
                Context.SaveChanges();
            }

            return session;
        }

        //if user updated session at 00:00, new session should be created
        private void CheckSessionTime()
        {
            if (DateTime.Now.DayOfYear != Session.Date.DayOfYear)
                Session = new Session();
        }

        private void UpdateSession()
        {
            Context.Sessions.Update(Session);
            Context.SaveChanges();
        }

        private void ClearUserInput()
        {
            UserTranslation = string.Empty;
        }

        private void GetNextWord()
        {
            Random rand = new Random();
            var Translations = Context.Translations.Where(t => !t.Completed);
            int translationCount = Translations.Count();
            int skip = rand.Next(0, translationCount);
            ActualTranslation = Translations.Skip(skip).FirstOrDefault() ?? new Translation{ ID=-1, WordToTranslate = "No words to translate :("};

            WordToTranslate = ActualTranslation.WordToTranslate;
            Translation = ActualTranslation.WordTranslation;
            Placeholder = $"Translate to {ActualTranslation.Language}";
        }
    }
}
