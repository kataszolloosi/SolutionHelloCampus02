using LieferkostenBerechnung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LieferkostenBerechnung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        LieferkostenBerechnen lieferkosten = null;
        public MainWindow()
        {
            InitializeComponent();
            lieferkosten = new LieferkostenBerechnen();
            this.DataContext = lieferkosten;
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            RepeatButton repeatButton = sender as RepeatButton;
            if(repeatButton.Content.ToString() == "+")
            {
                lieferkosten.GesamtGewicht++;
            } else
            {
                lieferkosten.GesamtGewicht--;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lieferkosten.Laender.Add("IT");
        }
    }
}
