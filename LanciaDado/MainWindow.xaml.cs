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

namespace LanciaDado
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

        private void LanciaIlDado_Click(object sender, RoutedEventArgs e)
        {
            int numero = int.Parse(TxtNumero.Text);            
            Random random = new Random();
            int numeroCasuale = random.Next(1,6);
            if (numero==numeroCasuale)
            {
                TxtRisultato.Text = numeroCasuale + " Complimenti hai vinto";
            }
            else
            {
                TxtRisultato.Text = numeroCasuale + " Mi dispiace hai perso";
            }
            if (numero < 1 || numero > 6)
            {
                MessageBox.Show("il numero non è valido","Attenzione",MessageBoxButton.OK,MessageBoxImage.Hand);
            }
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            TxtNumero.Clear();
            TxtNumero.Clear();
        }
    }
}
