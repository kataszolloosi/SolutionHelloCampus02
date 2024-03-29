﻿using System;
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

        private int _FilmId;

        public int FilmId
        {
            get { return _FilmId; }
            set { _FilmId = value; }
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

        private string _Bild;

        public string Bild
        {
            get { return _Bild; }
            set { _Bild = value; }
        }
    }
}
