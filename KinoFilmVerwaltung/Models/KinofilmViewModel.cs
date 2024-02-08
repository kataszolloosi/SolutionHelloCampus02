using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinoFilmVerwaltung.Models
{
    internal class KinofilmViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyGUI(string propName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }


        public ObservableCollection<KinoFilm> films { get; set; }

        private KinoFilm _SelectedKinoFilm;

        public KinoFilm SelectedKinoFilm
        {
            get { return _SelectedKinoFilm; }
            set { _SelectedKinoFilm = value; 
                NotifyGUI("SelectedKinoFilm");
            }
        }

        private string _Titel;

        public string Titel
        {
            get { return _Titel; }
            set { _Titel = value; }
        }

        public void AddKinoFilm(KinoFilm kinoFilm)
        {
            films.Add(kinoFilm);
            Titel = "Es sind " + kinoFilm.Titel + " Filme in der Liste";
            NotifyGUI("Titel");
        }

    }
}
