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

namespace LanciaDadi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    
        private void Bottone1_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(TxtNumero.Text);
            if (a < 1 || a > 6)
            {
                MessageBox.Show("il numero inserito non è corretto", "errore", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            else
            {
                Random r = new Random();
                int b = r.Next(1, 6);
                if (a == b)
                {
                    TxtNumero.Text = string.Format("hai vinto");
                }
                else
                {
                    TxtNumero.Text = string.Format("hai perso");
                    a = 0;
                    b = 0;
                    
                }
            }

        }
        private void Bottone2_Click(object sender, RoutedEventArgs e)
        {
            {
                TxtNumero.Text = "";
            }
        }
    }
}
