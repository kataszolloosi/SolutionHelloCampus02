using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoFilmVerwaltung.Models
{
    internal class KinoFilm :INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyGUI(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        private string _Titel;

        public string Titel
        {
            get { return _Titel; }
            set { _Titel = value; }
        }

        private string _Genre;

        public string Genre
        {
            get { return _Genre; }
            set { _Genre = value; }
        }

        private string _Originalsprache;

        public string Originalsprache
        {
            get { return _Originalsprache; }
            set { _Originalsprache = value; }
        }

        private double _Dauer;

        public double Dauer
        {
            get { return _Dauer; }
            set { _Dauer = value; }
        }


        public string Ausgabe { get; set; }


        private string _AusgewaehlteFilm;

        public string AusgewaehlteFilm
        {
            get { return _AusgewaehlteFilm; }
            set
            {
                _AusgewaehlteFilm = value;

                Ausgabe = $"{Titel} {Genre} {Originalsprache} {Dauer}";
                NotifyGUI("Ausgabe");
            }
        }



    }
}
