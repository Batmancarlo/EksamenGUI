using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using SmartCityWPF.Models;

namespace SmartCityWPF.ViewModels
{
    class LokationDetailsViewModel : BindableBase
    {
        private string currentID = "";
        private string currentNavn = "";
        private string currentVej = "";
        private string currentVejNummer = "";
        private string currentPostNummer = "";
        private string currentBy = "";
        private Lokationer lokation;
        private ObservableCollection<Maaletraer> currentLokationsMaaletraer;
      

        public LokationDetailsViewModel(Lokationer l)
        {
            lokation = l;
            currentID = Convert.ToString(l.LokationsID);
            currentNavn = l.Navn;
            currentVej = l.Vej;
            currentVejNummer = l.VejNummer;
            currentPostNummer = Convert.ToString(l.PostNummer);
            currentBy = l.By;
            currentLokationsMaaletraer = l.LokationensMaaletraers;
        }
       
        public String CurrentID
        {
            get { return currentID; }
            set { SetProperty(ref currentID, value); }
        }

        public ObservableCollection<Maaletraer> CurrentLokationsMaaletraer
        {
            get { return currentLokationsMaaletraer; }
            set { SetProperty(ref currentLokationsMaaletraer, value); }
        }


        public string CurrentNavn
        {
            get { return currentNavn; }
            set
            {
                SetProperty(ref currentNavn, value);
                lokation.Navn = currentNavn;
            }
        }

        public string CurrentVej
        {
            get { return currentVej; }
            set
            {
                SetProperty(ref currentVej, value);
                lokation.Vej = currentVej;
            }
        }

        public string CurrentVejNummer
        {
            get { return currentVejNummer; }
            set
            {
                SetProperty(ref currentVejNummer, value);
                lokation.VejNummer = currentVejNummer;
            }
        }

        public string CurrentPostNummer
        {
            get { return currentPostNummer; }
            set
            {
                SetProperty(ref currentPostNummer, value);
                lokation.PostNummer = Convert.ToInt32(currentPostNummer);
            }
        }

        public string CurrentBy
        {
            get { return currentBy; }
            set
            {
                SetProperty(ref currentBy, value);
                lokation.By = currentBy;
            }
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
        int currentIndex = 1;

        public int CurrentIndex
        {
            get { return currentIndex; }
            set { SetProperty(ref currentIndex, value); }
        }

        //Følgende er skreveet med udgangspunkt i løsningsforslaget til Agent Assignment 3 udleveret i GUI undervisningen
        ICommand _sletLokation;
        public ICommand SletLokation => _sletLokation ?? (_sletLokation =
                                            new DelegateCommand(DeleteAgent, DeleteLokation_CanExecute)
                                                .ObservesProperty(() => CurrentIndex));

        private void DeleteAgent()
        {
            CurrentLokationsMaaletraer.RemoveAt(CurrentIndex);
        }

        private bool DeleteLokation_CanExecute()
        {
            if (CurrentLokationsMaaletraer.Count > 0 && CurrentIndex >= 0)
                return true;
            else
                return false;
        }
        #endregion
    }
}
