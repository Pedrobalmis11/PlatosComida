
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

        ObservableCollection<Plato> listaPlatos = Plato.GetSamples(System.IO.Directory.GetCurrentDirectory() + "/Imagenes");
        public MainWindow()
        {
            InitializeComponent();

            ItemsListBox.DataContext = listaPlatos;
         
        }
    }
}
