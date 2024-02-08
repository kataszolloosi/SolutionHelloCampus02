using KinoFilmVerwaltung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KinoFilmVerwaltung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            KinofilmViewModel kinofilmViewModel = new KinofilmViewModel();
            kinofilmViewModel.films = new System.Collections.ObjectModel.ObservableCollection<KinoFilm>()
 {
                new KinoFilm() { FilmId = 1, Titel = "Star Wars", Genre = "Science Fiction", Bild = "starwars.jpg" },
                new KinoFilm() { FilmId = 2, Titel = "Indiana Jones", Genre = "Abenteuer", Bild = "indianajones.jpg" },
                new KinoFilm() { FilmId = 3, Titel = "James Bond", Genre = "Action", Bild = "jamesbond.jpg" }
            };

            this.DataContext = kinofilmViewModel;
        }
    }
}
