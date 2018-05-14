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
            Application.Current.Shutdown();
        }

        private void btTalca_Click(object sender, RoutedEventArgs e)
        {
            wndMain wndMain = new wndMain();
            wndMain.Minimizer();
        }
    }
}
