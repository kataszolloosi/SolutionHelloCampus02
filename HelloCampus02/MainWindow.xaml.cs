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

namespace HelloCampus02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new List<string>() { "Cheda", "Victoria" };
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            //aktuelle Uhrzeit im Titel anzeigen
            this.Title = DateTime.Now.ToString();
            
        }

        private void onChange(object sender, SelectionChangedEventArgs e)
        {
           //objekt kasten
            ListBox myListbox = sender as ListBox;
            //wenn der kasten erfolgreich
            if (myListbox != null)
            {
                //den Titel der Anwendung auf den Inhalt der Listbox setzen
                //kasten wir explizit in einem listbox item - kommt nur den inhalt als titel
                this.Title = ((ListBoxItem)myListbox.SelectedItem).Content.ToString();
            }
        }

        private void colorChange(object sender, SelectionChangedEventArgs e)
        {
            ComboBox myComboBox = sender as ComboBox;
            if (myComboBox != null)
            {
                ComboBoxItem selectedItem = (ComboBoxItem)myComboBox.SelectedItem;

                if (selectedItem != null)
                {
                    string selectedColor = selectedItem.Content.ToString();

                    if (selectedColor == "Red")
                    {
                        this.Background = Brushes.Red;
                    }
                    else if (selectedColor == "Green")
                    {
                        this.Background = Brushes.Green;
                    }
                    else if (selectedColor == "Blue")
                    {
                        this.Background = Brushes.Blue;
                    }
                }
            }
        }

        private void toggleColorChange(object sender, RoutedEventArgs e)
        {
            ToggleButton toggle = sender as ToggleButton;
            if (toggle != null)
            {
                if (toggle.IsChecked == true)
                {
                    this.Background = Brushes.DarkSlateBlue;
                }

                //if (toggleButton.IsChecked == true)   ---- mit button name zugreifen, brauchen wir nicht kasten
                //{
                //    this.Background = Brushes.DarkSlateBlue;
                //}
                else
                {
                    this.Background = Brushes.LightSteelBlue;
                }
            }
        }
    }
}
