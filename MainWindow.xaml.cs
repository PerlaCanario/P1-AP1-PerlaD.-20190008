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
using P1_AP1_PerlaD._20190008.UI.Registro;
namespace P1_AP1_PerlaD._20190008
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

        private void rAportes_Click(object sender, RoutedEventArgs e)
        {
            rAportes rAportes = new rAportes();
            rAportes.Show();
        }

        private void cAportes_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
