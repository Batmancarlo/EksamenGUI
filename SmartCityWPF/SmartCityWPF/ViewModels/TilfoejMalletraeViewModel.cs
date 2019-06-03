using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using SmartCityWPF.Models;

namespace SmartCityWPF.ViewModels
{
    public class TilfoejMalletraeViewModel : BindableBase
    {
        private ObservableCollection<Maaletraer> currentLokationsMaaletraer;
        private string currentAntal;
        private string currentTraeart; 

        public TilfoejMalletraeViewModel(ObservableCollection<Maaletraer> Maaletraer)
        {
            currentLokationsMaaletraer = Maaletraer;
        }

        public string CurrentAntal
        {
            get { return currentAntal; }
            set { SetProperty(ref currentAntal, value); }
        }

        public string CurrentTraeart
        {
            get { return currentTraeart; }
            set { SetProperty(ref currentTraeart, value); }
        }

        ICommand _tilfoejMaaletrae;

        public ICommand TilfoejMaaletrae
        {
            get
            {
                return _tilfoejMaaletrae ?? (_tilfoejMaaletrae = new DelegateCommand(() =>
                {
                    if (int.TryParse(CurrentAntal, out int n))
                    {
                        currentLokationsMaaletraer.Add(new Maaletraer(CurrentTraeart, Convert.ToInt32(CurrentAntal)));
                    }
                    else
                    {
                        string message = "Antal skal være et helt tal";
                        string caption = "Fejl i indtastet antal";
                        MessageBox.Show(message, caption);
                    }
                }));
            }
        }

    }
}
