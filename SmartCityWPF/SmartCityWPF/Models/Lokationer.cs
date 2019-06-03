using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace SmartCityWPF.Models
{
    public class Lokationer : BindableBase
    {
        private int lokationID;
        private string navn;
        private string vej;
        private string vejNummer;
        private int postNummer;
        private string by;
        private ObservableCollection<Maaletraer> lokationensMaaletraer;

        public Lokationer() {}

        public Lokationer(int nytID, string nytNavn, string nyVej, string nytVejNummer, int nytPostNummer, string nyBy,
            ObservableCollection<Maaletraer> nyeLokationensMaaletraer)
        {
            lokationID = nytID;
            navn = nytNavn;
            vej = nyVej;
            vejNummer = nytVejNummer;
            postNummer = nytPostNummer;
            by = nyBy;
            lokationensMaaletraer = nyeLokationensMaaletraer;
        }

        public ObservableCollection<Maaletraer> LokationensMaaletraers
        {
            get { return lokationensMaaletraer; }
            set { SetProperty(ref lokationensMaaletraer, value); }
        }

        public int LokationsID
        {
            get { return lokationID; }
            set { SetProperty(ref lokationID, value); }
        }

        public string Navn
        {
            get { return navn; }
            set { SetProperty(ref navn, value); }

        }

        public string Vej
        {
            get { return vej; }
            set { SetProperty(ref vej, value); }

        }

        public string VejNummer
        {
            get { return vejNummer; }
            set { SetProperty(ref vejNummer, value); }

        }


        public int PostNummer
        {
            get { return postNummer; }
            set { SetProperty(ref postNummer, value); }

        }

        public string By
        {
            get { return by; }
            set { SetProperty(ref by, value); }

        }


    }
}
