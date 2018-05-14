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

namespace Bill_It.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class wndMain : Window
    {
        private ucLogin ucloginPage;
        private bool clicado = false;
        private Point lm = new Point();

        public wndMain()
        {
            InitializeComponent();

            mainGrid.Children.Add(ucloginPage = new ucLogin(mainGrid));
            

        }

        

        public void Minimizer()
        {
            this.WindowState = WindowState.Minimized;
        }

        private void mainGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void mainGrid_MouseMove(object sender, MouseEventArgs e)
        {
            
          
        }
    }
}
