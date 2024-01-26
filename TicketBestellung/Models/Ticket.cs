using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketBestellung.Models
{
    internal class Ticket : INotifyPropertyChanged
    {
        //public decimal Price { get; set; }
        //public decimal Summe { get; set; }
        //public int Number { get; set; }
        //public string Color { get; set; }

        public Ticket()
        {
            Ticketarten = new List<string>()
        {
            "Konzert",
            "Kino",
            "Museum",
            "Eishockey",
        };

        }

        private string _ausgewaehlteTicketArt;

        public string AusgewaehlteTicketArt
        {
            get { return _ausgewaehlteTicketArt; }
            set { _ausgewaehlteTicketArt = value;
                NotifyGui("AusgewaehlteTicketArt");
            }
        }


        private double _Price;

        public double Price
        {
            get { return _Price; }
            set
            {
                _Price = value;
                updateAll();

            }
        }

        private int _number;

        public int Number
        {
            get { return _number; }
            set
            {
                _number = value;
                //NotifyGui("Number");    ---nur wenn wir möchten etwas anzeigen
                updateAll();
            }
        }

        private string _color;

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }


        private double _summe;

        public double Summe
        {
            get { return _summe; }
            set { _summe = value; }
        }


        private void updateAll()
        {
            updateColor();
            updateSumme();
        }

        private void updateSumme()
        {
            Summe = Price * Number;
            NotifyGui("Summe");
        }

        private void updateColor()
        {
            if (Summe < 1000)
            {
                Color = "Green";
            }
            else
            {
                Color = "Red";
            }
            NotifyGui("Color");
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyGui(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public List<string> Ticketarten { get; set; }
    }
}
