using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;
using Prism.Commands;
using Prism.Mvvm;
using SmartCityWPF.Data;
using SmartCityWPF.Models;

namespace SmartCityWPF.ViewModels
{
    class MainWindowViewModel : BindableBase
    {
        private string filePath = "";
        private string searchBarString = "";
        private string currentNavn = "";
        private string currentVej = "";
        private string currentVejNummer = "";
        private string currentPostNummer = "";
        private string currentBy = "";
        private ObservableCollection<Maaletraer> currentLokationsMaaletraer;
        private ObservableCollection<Lokationer> currentLokationer;
        private ObservableCollection<Lokationer> alleLokationer;

        public MainWindowViewModel()
        {
            CurrentLokationer = new ObservableCollection<Lokationer>();
            AlleLokationer = new ObservableCollection<Lokationer>();
            CurrentLokationsMaaletraer = new ObservableCollection<Maaletraer>();

        }

        public String SearchBarString
        {
            get { return searchBarString; }
            set
            {
                SetProperty(ref searchBarString, value);
                CurrentLokationer = new ObservableCollection<Lokationer>(
                    AlleLokationer.Where(lokation => lokation.Navn.StartsWith(searchBarString)));
            }
        }

        public ObservableCollection<Lokationer> CurrentLokationer
        {
            get { return currentLokationer; }
            set { SetProperty(ref currentLokationer, value); }
        }

        public ObservableCollection<Lokationer> AlleLokationer
        {
            get { return alleLokationer; }
            set { SetProperty(ref alleLokationer, value); }
        }

        public ObservableCollection<Maaletraer> CurrentLokationsMaaletraer
        {
            get { return currentLokationsMaaletraer; }
            set { SetProperty(ref currentLokationsMaaletraer, value); }
        }


        public string CurrentNavn
        {
            get { return currentNavn; }
            set { SetProperty(ref currentNavn, value); }
        }

        public string CurrentVej
        {
            get { return currentVej; }
            set { SetProperty(ref currentVej, value); }
        }

        public string CurrentVejNummer
        {
            get { return currentVejNummer; }
            set { SetProperty(ref currentVejNummer, value); }
        }

        public string CurrentPostNummer
        {
            get { return currentPostNummer; }
            set { SetProperty(ref currentPostNummer, value); }
        }

        public string CurrentBy
        {
            get { return currentBy; }
            set { SetProperty(ref currentBy, value); }
        }

        ICommand _gemLokation;

        public ICommand GemLokation
        {
            get
            {
                return _gemLokation ?? (_gemLokation = new DelegateCommand(() =>
                {
                    if (int.TryParse(CurrentPostNummer, out int n))
                    {

                        Lokationer nyLokation = new Lokationer(generateID(), CurrentNavn, CurrentVej, CurrentVejNummer,
                            Convert.ToInt32(CurrentPostNummer), CurrentBy, new ObservableCollection<Maaletraer>(CurrentLokationsMaaletraer));

                        AlleLokationer.Add(nyLokation);
                        Dirty = true;
                        SearchBarString = SearchBarString;
                        CurrentLokationsMaaletraer.Clear();
                        CurrentNavn = "";
                        CurrentVej = "";
                        CurrentVejNummer = "";
                        CurrentPostNummer = "";
                        CurrentBy = "";
                    }
                    else
                    {
                        string message = "Postnummer skal være et helt tal";
                        string caption = "Fejl i indtastet Postnummer";
                        MessageBox.Show(message, caption);
                    }
                }));
            }
        }

        int currentIndex = 1;

        public int CurrentIndex
        {
            get { return currentIndex; }
            set { SetProperty(ref currentIndex, value); }
        }

        private ICommand _tilfoejMaaletrae;

        public ICommand TilfoejMaaletrae
        {
            get
            {
                return _tilfoejMaaletrae ?? (_tilfoejMaaletrae = new DelegateCommand(() =>
                {

                    var vm = new TilfoejMalletraeViewModel(currentLokationsMaaletraer);

                    var dlg = new TilfoejMalletraeWindow()
                    {
                        DataContext = vm
                    };

                    dlg.Owner = App.Current.MainWindow;

                    
                    if (dlg.ShowDialog() == true)
                    {
                      dlg.Close();
                    }
                }));
            }

        }

        #region sletfunktionalitet
        //Følgende er skreveet med udgangspunkt i løsningsforslaget til Agent Assignment 3 udleveret i GUI undervisningen
        ICommand _sletLokation;
            public ICommand SletLokation => _sletLokation ?? (_sletLokation =
                                                      new DelegateCommand(DeleteAgent, DeleteLokation_CanExecute)
                                                          .ObservesProperty(() => CurrentIndex));

            private void DeleteAgent()
        {
            AlleLokationer.RemoveAt(CurrentIndex);
            SearchBarString = SearchBarString;
        }

        private bool DeleteLokation_CanExecute()
        {
            if (AlleLokationer.Count > 0 && CurrentIndex >= 0)
                return true;
            else
                return false;
        }
        #endregion

        private int generateID()
        {
            bool newIDFound = false;
            int newID = 0;
            Random random = new Random();

            while (newIDFound != true)
            {
                newID = random.Next(1000, 9999);
                newIDFound = true;

                foreach (var lokation in AlleLokationer)
                {
                   if( lokation.LokationsID == newID)
                   {
                       newIDFound = false;
                   }
                }
                
            }
            return newID;
        }

        private bool dirty = false;
        public bool Dirty
        {
            get { return dirty; }
            set
            {
                SetProperty(ref dirty, value);
                RaisePropertyChanged("Title");
            }
        }

        Lokationer currentLokation = null;

        public Lokationer CurrentLokation
        {
            get { return currentLokation; }
            set { SetProperty(ref currentLokation, value); }
        }


        private ICommand _lokationDetails;

        public ICommand LokationDetails
        {
            get
            {
                return _lokationDetails ?? (_lokationDetails = new DelegateCommand(() =>
                {

                    var vm = new LokationDetailsViewModel(currentLokation);

                    var dlg = new LokationDetailsWindow()
                    {
                        DataContext = vm
                    };

                    dlg.Owner = App.Current.MainWindow;

                    dlg.Show();
                }));
            }

        }

        #region SaveAndOpenFiles
       
        //Følgende 10 funktioner er skrevet med udgangspunkt i løsningsforslaget til Agent Assignment, udleveret i forbindelse med GUI undervisningen. 
        public string Title
        {
            get
            {
                var s = "";
                if (Dirty)
                    s = "*";
                return Filename + s + " - " + "Aarhus SmarTree";
            }
        }

        private string filename = "";
        public string Filename
        {
            get { return filename; }
            set
            {
                SetProperty(ref filename, value);
                RaisePropertyChanged("Title");
            }
        }

        ICommand _OpenFileCommand;
        public ICommand OpenFileCommand
        {
            get { return _OpenFileCommand ?? (_OpenFileCommand = new DelegateCommand<string>(OpenFileCommand_Execute)); }
        }

        private void OpenFileCommand_Execute(string argFilename)
        {
            var dialog = new OpenFileDialog
            {
                Filter = "Aarhus SmarTree documents|*.ast|All Files|*.*",
                DefaultExt = "ast"
            };
            if (filePath == "")
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            else
                dialog.InitialDirectory = Path.GetDirectoryName(filePath);

            if (dialog.ShowDialog(App.Current.MainWindow) == true)
            {
                filePath = dialog.FileName;
                Filename = Path.GetFileName(filePath);
                try
                {
                    Repository.ReadFile(filePath, out ObservableCollection<Lokationer> tempLokationer);
                    AlleLokationer = tempLokationer;
                    SearchBarString = "";
                    Dirty = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Unable to open file", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        ICommand _SaveAsCommand;
        public ICommand SaveAsCommand
        {
            get { return _SaveAsCommand ?? (_SaveAsCommand = new DelegateCommand<string>(SaveAsCommand_Execute)); }
        }

        private void SaveAsCommand_Execute(string argFilename)
        {
            var dialog = new SaveFileDialog
            {
                Filter = "Aarhus SmarTree documents|*.ast|All Files|*.*",
                DefaultExt = "ast"
            };
            if (filePath == "")
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            else
                dialog.InitialDirectory = Path.GetDirectoryName(filePath);

            if (dialog.ShowDialog(App.Current.MainWindow) == true)
            {
                filePath = dialog.FileName;
                Filename = Path.GetFileName(filePath);
                SaveFile();
            }
        }

        ICommand _SaveCommand;
        public ICommand SaveCommand
        {
            get
            {
                return _SaveCommand ?? (_SaveCommand = new DelegateCommand(SaveFileCommand_Execute, SaveFileCommand_CanExecute)
                           .ObservesProperty(() => AlleLokationer.Count));
            }
        }

        private void SaveFileCommand_Execute()
        {
            SaveFile();
        }

        private bool SaveFileCommand_CanExecute()
        {
            return (filename != "") && (AlleLokationer.Count > 0);
        }

        private void SaveFile()
        {
            try
            {
                Repository.SaveFile(filePath, AlleLokationer);
                Dirty = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to save file", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        #endregion
    }
}

