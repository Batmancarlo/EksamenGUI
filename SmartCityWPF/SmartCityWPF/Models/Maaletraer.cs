using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace SmartCityWPF.Models
{
    public class Maaletraer : BindableBase
    {
        private string traeArt;
        private int antalTraer;

        public Maaletraer() { }

        public Maaletraer(string nyTraeArt, int nytAntalTraer)
        {
            traeArt = nyTraeArt;
            antalTraer = nytAntalTraer;
        }
        
        public string TraeArt
        {
            get { return traeArt; }
            set { SetProperty(ref traeArt, value); }

        }

        public int AntalTraer
        {
            get { return antalTraer; }
            set { SetProperty(ref antalTraer, value); }
        }


    }
}
