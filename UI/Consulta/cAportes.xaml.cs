using P1_AP1_PerlaD._20190008.BLL;
using P1_AP1_PerlaD._20190008.Entidades;
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

namespace P1_AP1_PerlaD._20190008.UI.Consulta
{
    /// <summary>
    /// Lógica de interacción para cAportes.xaml
    /// </summary>
    public partial class cAportes : Window
    {
        public cAportes()
        {
            InitializeComponent();
        }
        private void ConsultarButton_Click(object sender, RoutedEventArgs e)
        {
            var listado = new List<Aportes>();

            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltroComboBox.SelectedIndex)
                {
                    case 0:
                        listado = AportesBLL.GetList(e => e.AportesId == Convert.ToInt32(CriterioTextBox.Text));
                        break;

                    case 1:
                        listado = AportesBLL.GetList(e => e.Persona.Contains(CriterioTextBox.Text));
                        break;
                }
            }
            else
            {
                listado = AportesBLL.GetList(c => true);
            }

            AportesDataGrid.ItemsSource = null;
            AportesDataGrid.ItemsSource = listado;
        }
    }
}
