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

namespace Esercizio
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

        List<string> lista = new List<string>();
        int c = 0;

        private void btninserisci_Click(object sender, RoutedEventArgs e)
        {
            string frase = txtFrase.Text;
            lista.Add(frase);
            txtFrase.Clear();
            txtFrase.Focus();
            c++;
            if (c == 5)
            {
                btninserisci.IsEnabled = false;
                btnstampa.IsEnabled = true;
                btnordina.IsEnabled = true;
                btnpubblica.IsEnabled = true; 
            }
        }

        private void btnstampa_Click(object sender, RoutedEventArgs e)
        {
            txtInserite.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                txtInserite.Text += $" Posizione {i} : {lista[i]}\n";
            }
        }

        private void btnordina_Click(object sender, RoutedEventArgs e)
        {
            lista.Sort();
            txtOrdinate.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                txtOrdinate.Text += $" Posizione {i} : {lista[i]}\n ";
            }
        }

        //da finire il bottone pubblica
    }
}
