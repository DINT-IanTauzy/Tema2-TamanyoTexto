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

namespace Tema2_TamanyoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton button = (RadioButton)sender;
            string tag = (String)button.Tag;
            switch(tag)
            {
                case "Pequeño":
                    TituloTextBlock.FontSize = 36;
                    break;
                case "Mediano":
                    TituloTextBlock.FontSize = 48;
                    break;
                case "Grande":
                    TituloTextBlock.FontSize = 58;
                    break;
            }
        }
    }
}
