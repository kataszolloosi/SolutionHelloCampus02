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

        public string Titel { get; set; }
        public string Genre { get; set; }
        public string Originalsprache { get; set; }
        public double Dauer { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }


        public KinoFilm()
        {
            kinoFilms = new List<KinoFilm>()
            {
                new KinoFilm() {Titel = "Film1", Genre = "Genre1", Originalsprache = "Sprache1", Dauer = 1.5},
                new KinoFilm() {Titel = "Film2", Genre = "Genre2", Originalsprache = "Sprache2", Dauer = 2.5},
                new KinoFilm() {Titel = "Film3", Genre = "Genre3", Originalsprache = "Sprache3", Dauer = 3.5}
            };
        }


        public List<KinoFilm> kinoFilms { get; set; }

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
