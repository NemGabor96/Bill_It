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
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using Bill_It.View;
using Bill_It.Control;
using Bill_It.Model;

namespace Bill_It.View
{
    /// <summary>
    /// Interaction logic for wndRegistration.xaml
    /// </summary>
    public partial class wndRegistration : Window
    {
        public wndRegistration()
        {
            InitializeComponent();
        }

        private void tbIranyitoszam_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            wndRegistrationClass.InputRegularExpressionNumbers(e);
        }

        private void tbCsaladtagok_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            wndRegistrationClass.InputRegularExpressionNumbers(e);
        }

        private void btEsc_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btRegisztráció_Click(object sender, RoutedEventArgs e)
        {
            wndRegistrationClass wndRegistrationClass = new wndRegistrationClass();
            wndRegistrationClass.RegistrationButtonClick(tbFelhasznalonev.Text,pbJelszo.Password,pbJelszoMegerosites.Password,tbVezeteknev.Text,
                tbKeresztnev.Text,tbVaros.Text,tbIranyitoszam.Text,tbUtcaHazszam.Text,tbCsaladtagok.Text,cbFAQOlvasas);
        }
    }
}
