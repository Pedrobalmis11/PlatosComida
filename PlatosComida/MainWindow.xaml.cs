
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace PlatosComida
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int num = 0;
        ObservableCollection<Plato> listaPlatos = Plato.GetSamples(System.IO.Directory.GetCurrentDirectory() + "/Imagenes");
        public MainWindow()
        {
            InitializeComponent();
            
            ItemsListBox.DataContext = listaPlatos;

            //contenedorStackPanel.DataContext = listaPlatos;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //nombreTextBlock.Text = listaPlatos[ItemsListBox.SelectedIndex].Nombre;
            //MessageBox.Show(ItemsListBox.SelectedIndex + "", "Superhéroes", MessageBoxButton.OK, MessageBoxImage.Information);
            //MessageBox.Show(((Plato)ItemsListBox.SelectedItem).Nombre.ToString(), "Superhéroes", MessageBoxButton.OK, MessageBoxImage.Information);
            //MessageBox.Show(ItemsListBox.SelectedValue.ToString(), "Superhéroes", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ItemsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            nombreTextBox.Text = listaPlatos[ItemsListBox.SelectedIndex].Nombre;
            imagenTextBox.Text = listaPlatos[ItemsListBox.SelectedIndex].Imagen;

            if(listaPlatos[ItemsListBox.SelectedIndex].Tipo == "China")
            {
                chinaComboBox. = true;
            }
        }
    }
}
