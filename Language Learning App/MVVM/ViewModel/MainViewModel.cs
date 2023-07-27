using Language_Learning_App.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Learning_App.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand LearnViewCommand { get; set; }
        public RelayCommand DatabaseViewCommand { get; set; }
        public RelayCommand StatsViewCommand { get; set; }

        private object? _currentView;
        public LearnViewModel LearnVM { get; set; }
        public DatabaseViewModel DatabaseVM { get; set; }
        public StatsViewModel StatsVM { get; set; }
        public object? CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public MainViewModel()
        {
            LearnVM = new LearnViewModel();
            DatabaseVM = new DatabaseViewModel();
            StatsVM = new StatsViewModel();
            CurrentView = LearnVM;

            LearnViewCommand = new RelayCommand(o =>
            {
                CurrentView = LearnVM;
            });

            DatabaseViewCommand = new RelayCommand(o =>
            {
                CurrentView = DatabaseVM;
            });

            StatsViewCommand = new RelayCommand(o =>
            {
                CurrentView = StatsVM;
            });
        }
    }
}
