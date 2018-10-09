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

namespace Help_Desk.Apresentacao
{
    /// <summary>
    /// Lógica interna para frmMenu.xaml
    /// </summary>
    public partial class frmMenu : Window
    {
        public frmMenu()
        {
            InitializeComponent();

            if (Modelo.atbEstaticos.id_Funcionario == 0)
            {
                this.mniAdministrador.IsEnabled = false;

            }
        }



    private void mniCadastrar_Click(object sender, RoutedEventArgs e)
        {
            frmChamado frmChamado = new frmChamado();
            frmChamado.ShowDialog();
        }

        private void mniVisualizar_Click(object sender, RoutedEventArgs e)
        {
            frmPEE frmPEE = new frmPEE();
            frmPEE.ShowDialog();
        }

        private void btnVoltar_Click(object sender, RoutedEventArgs e)
        {
            Close();
            
        }
    }
}
