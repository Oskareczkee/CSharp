using Language_Learning_App.Core;
using Language_Learning_App.DB;
using Language_Learning_App.DB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Documents;

namespace Language_Learning_App.MVVM.ViewModel
{
    public class DatabaseViewModel : ObservableObject
    {
        private readonly Context Context = new Context();
        public readonly IEnumerable<Session> Sessions;
        private ObservableCollection<Translation> _Translations = null!;

        public RelayCommand SaveCommand { get; set; }
        public RelayCommand SaveToFileCommand { get; set; }
        public RelayCommand ImportCommand { get; set; } 
        public RelayCommand ResetCommand { get; set; }

        public ObservableCollection<Translation> Translations
        {
            get { return _Translations; }
            set { _Translations = value; OnPropertyChanged(nameof(Translations)); }
        }
        public DatabaseViewModel()
        {
            Context.Translations.Load();
            Translations = Context.Translations.Local.ToObservableCollection();

            //take user, we do not have multiple users yet, so we just take the first, also user should not be kept here
            User user = Context.Users.First();
            //In real program consider using dependency injection
            Sessions = Context.Sessions.Where(s => s.UserID == user.ID).ToList();

            SaveCommand = new RelayCommand(c =>
            {
                Context.SaveChanges();
            });

            ResetCommand = new RelayCommand(c =>
            {
                foreach (var t in Translations)
                    t.Completed = false;
            });

            SaveToFileCommand = new RelayCommand(c =>
            {
                var dialog = new SaveFileDialog();
                dialog.AddExtension = true;
                dialog.DefaultExt = ".json";
                dialog.Filter = "Translation Files (*.txt;*.json)|*.txt;*.json";

                if(dialog.ShowDialog()==true)
                {
                    string FileName = dialog.FileName;
                    string extension = Path.GetExtension(FileName);
                    using StreamWriter sw = new StreamWriter(FileName);
                    List<Translation> translations = Context.Translations.ToList();
                    switch(extension)
                    {
                        case ".txt":
                            {
                                foreach (var trans in translations)
                                    sw.WriteLine($"{trans.WordToTranslate} {trans.WordTranslation} {trans.Language}");
                                break;
                            }
                        case ".json":
                            {
                                sw.Write(JsonSerializer.Serialize(translations, new JsonSerializerOptions { WriteIndented=true} ));
                                break;
                            }
                        default:
                            break;
                    }
                }
            });

            ImportCommand = new RelayCommand(c =>
            {
                var dialog = new OpenFileDialog();
                dialog.Filter = "Translation Files(*.txt;*.json)|*.txt;*.json";
                dialog.RestoreDirectory = true;

                if(dialog.ShowDialog()==true)
                {
                    string extension = Path.GetExtension(dialog.FileName);
                    if(extension==".json")
                    {
                        string json = File.ReadAllText(dialog.FileName);
                        var obj = JsonSerializer.Deserialize<List<Translation>>(json) ?? new List<Translation>();

                        foreach (var t in obj)
                            Context.Translations.Add(t);
                    }
                    else if (extension == ".txt")
                    {
                        var lines = File.ReadAllLines(dialog.FileName);
                        foreach (string line in lines)
                        {
                            // FORMAT: WordToTranslate WordTranslation LanguageIdentifier (string)
                            var split = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                            //invalid entity, just skip it
                            if (split.Length < 3)
                                continue;

                            Language lang = Enum.Parse<Language>(split[2], true);

                            //language is not defined, skip
                            if (!Enum.IsDefined<Language>(lang))
                                continue;

                            Context.Translations.Add(new Translation { WordToTranslate = split[0], WordTranslation = split[1], Language = lang });
                        }
                    }
                    else
                        return;
                }
            });
        }
    }
}
