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
using Bill_It.View;
using Bill_It.Control;


namespace Bill_It.View
{
    /// <summary>
    /// Interaction logic for ucLogin.xaml
    /// </summary>
    public partial class ucLogin : UserControl
    {
        private Grid mainGrid;

        public ucLogin(Grid mainGrid)
        {
            InitializeComponent();
            this.mainGrid = mainGrid;

        }

        private void btEsc_Click(object sender, RoutedEventArgs e)
        {
            ucLoginClass.btEsc_Click();
        }

        private void btTalca_Click(object sender, RoutedEventArgs e)
        {
            ucLoginClass.btTalca_Click();
        }
        
        private void btRegisztracio_Click(object sender, RoutedEventArgs e)
        {
            ucLoginClass.btRegisztracio_Click();
        }

        private void btBelepes_Click(object sender, RoutedEventArgs e)
        {
            if (ucLoginClass.btBelepes_Click(tbFelhasznalo.Text, pwJelszo.Password) == true)

            {
              
                lbFelhasznalo.Foreground = Brushes.Green;
                lbJelszo.Foreground = Brushes.Green;
                lbHibaFelJel.Visibility = Visibility.Hidden;
                ucMainMenu ucMain;
                mainGrid.Children.Clear();
                mainGrid.Children.Add(new ucMainMenu(mainGrid));
            }
            else
            {
                
                lbFelhasznalo.Foreground = Brushes.Red;
                lbJelszo.Foreground = Brushes.Red;
                lbHibaFelJel.Visibility = Visibility.Visible;
            }
           
        }

        private void grMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if(ucLoginClass.btBelepes_Click(tbFelhasznalo.Text, pwJelszo.Password) == true)

                   {
                    
                    lbFelhasznalo.Foreground = Brushes.Green;
                    lbJelszo.Foreground = Brushes.Green;
                    lbHibaFelJel.Visibility = Visibility.Hidden;
                    ucMainMenu ucMain;
                    mainGrid.Children.Clear();
                    mainGrid.Children.Add(new ucMainMenu(mainGrid));
                }
                else
                {
                    
                    lbFelhasznalo.Foreground = Brushes.Red;
                    lbJelszo.Foreground = Brushes.Red;
                    lbHibaFelJel.Visibility = Visibility.Visible;
                }
            }
        }
    }
}
