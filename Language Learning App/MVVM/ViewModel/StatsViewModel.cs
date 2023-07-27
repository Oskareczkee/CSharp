using Language_Learning_App.Core;
using Language_Learning_App.DB;
using Language_Learning_App.DB.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Learning_App.MVVM.ViewModel
{
    public class StatsViewModel : ObservableObject
    {
        public User User { get; set; }
        private readonly Context Context = new Context();

        public string Header { get; set; } = string.Empty;
        public string CompletionPercent { get; set; } = string.Empty;

        public List<Session> Sessions { get; set; }

        public StatsViewModel()
        {
            User = Context.Users.First();
            Header = $"{User.Name}'s Stats";

            Sessions = Context.Sessions.Where(s => s.UserID == User.ID).ToList();

            double CompletedCount = Context.Translations.Where(t => t.Completed).Count();
            double Percent = CompletedCount / Context.Translations.Count();
            CompletionPercent = Percent.ToString("P");
        }
    }
}
