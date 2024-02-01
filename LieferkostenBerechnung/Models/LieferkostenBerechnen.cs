using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LieferkostenBerechnung.Models
{
    internal class LieferkostenBerechnen : INotifyPropertyChanged
    {
        #region PropertyChange
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyGui(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        #endregion

        public LieferkostenBerechnen()
        {
            Laender = new List<string> { "DE", "USA", "HUN" };

            ObsListeLaender = new ObservableCollection<Land>()
            {
                new Land(){Bezeichnung="Austria",Flagge="Austria.png",Kosten=7},
                new Land(){Bezeichnung="Germany",Flagge="DE.png",Kosten=7},

            };
        }

        public List<string> Laender { get; set; }


        public string _AusgewLand;
        public string AusgewLand
        {
            get { return _AusgewLand; }
            set
            {
                if (_AusgewLand != value)
                {
                    _AusgewLand = value;
                    OnLandChange();
                }
            }
        }

        private double _KostenProKilo;

        public double KostenProKilo
        {
            get { return _KostenProKilo; }
            set { _KostenProKilo = value; }
        }

        private string _Flagge;

        public string Flagge
        {
            get { return _Flagge; }
            set { _Flagge = value; }
        }


        private string _Ausgabetext;

        public string Ausgabetext
        {
            get { return _Ausgabetext; }
            set { _Ausgabetext = value; }
        }

        private int _GesamtGewicht;

        public int GesamtGewicht
        {
            get { return _GesamtGewicht; }
            set
            {
                _GesamtGewicht = value;
                OnLandChange();
                NotifyGui("GesamtGewicht");
            }
        }

        private bool _isExpress;

        public bool isExpress
        {
            get { return _isExpress; }
            set
            {
                _isExpress = value;

                OnLandChange();
                NotifyGui("isExpress");
            }
        }



        private void OnLandChange()
        {
            switch (AusgewLand)
            {
                case "DE":
                    KostenProKilo = 12;
                    Flagge = "deutsch.png";
                    break;

                case "USA":
                    KostenProKilo = 20;
                    Flagge = "usa.png";
                    break;
                case "HUN":
                    KostenProKilo = 25;
                    Flagge = "hun.png";
                    break;
                default:
                    break;
            }

            var gesamtPreis = GesamtGewicht * KostenProKilo;
            if (isExpress)
            {
                gesamtPreis *= 1.1;
            }


            Ausgabetext = $"Sie haben {AusgewLand} ausgewählt. Hier kostet ein Kilo {KostenProKilo} GesamtGewicht {GesamtGewicht} Express {isExpress} GesamtPreis {gesamtPreis}";
            NotifyGui("KostenProKilo");
            NotifyGui("Flagge");
            NotifyGui("Ausgabetext");
        }

        public ObservableCollection<Land> ObsListeLaender { get; set; }

        public string AusgabeVariante2 { get; set; }


        private Land _AusgewaehltesLandObject;

        public Land AusgewaehltesLandObject
        {
            get { return _AusgewaehltesLandObject; }
            set
            {
                _AusgewaehltesLandObject = value;

                AusgabeVariante2 = $"Sie haben gewählt {AusgewaehltesLandObject.Bezeichnung} Kosten: {AusgewaehltesLandObject.Kosten}";
                NotifyGui("AusgabeVariante2");
            }

        }
    }
}
