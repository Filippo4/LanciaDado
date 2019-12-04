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
            int numeroCasuale = random.Next(1,7);
            int puntata = int.Parse(Txt_Puntata.Text);
            int credito = int.Parse(Lbl_credito.Content.ToString());
            if (puntata <= credito)
            {
                if (numero == numeroCasuale)
                {
                    TxtRisultato.Text = numeroCasuale + " Complimenti hai vinto";
                    credito = credito + (puntata * 4);
                    Lbl_credito.Content = credito;
                }
                else
                {
                    TxtRisultato.Text = numeroCasuale + " Mi dispiace hai perso";
                    credito = credito - puntata;
                    Lbl_credito.Content = credito;
                }
                Uri resourceUri = new Uri($"/Images/dado{numeroCasuale}.png", UriKind.Relative);
                Img_Dado.Source = new BitmapImage(resourceUri);
                if (numero < 1 || numero > 6)
                {
                    MessageBox.Show("il numero non è valido", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Hand);
                }
                if(credito == 0)
                {
                    MessageBox.Show("Game Over non hai più soldi", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Hand);
                }
            }else
            {
                MessageBox.Show("Non puoi puntare quello che non hai", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            TxtNumero.Clear();
            TxtRisultato.Clear();
            Lbl_credito.Content = 100;
            Txt_Puntata.Clear();
        }
    }
}
