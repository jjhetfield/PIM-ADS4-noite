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
    /// Interaction logic for frmChamado.xaml
    /// </summary>
    public partial class frmChamado : Window
    {
        public frmChamado()
        {
            InitializeComponent();

            Modelo.Controle controle = new Modelo.Controle();
            controle.PesquisaSolicitantePorID(Modelo.atbEstaticos.id_Usuario);
            txbSolicitante.Text = Modelo.atbEstaticos.nome_Usuario;
            txbData.Text = DateTime.Now.ToShortDateString();
        }

        private void btnLimpar_Click(object sender, RoutedEventArgs e)
        {
            LimparCampos();
        }

        private void btnSolicitar_Click(object sender, RoutedEventArgs e)
        {
            List<String> dadoschamado = new List<string>();
            dadoschamado.Add("0");
            dadoschamado.Add(Modelo.atbEstaticos.id_Usuario.ToString());
            dadoschamado.Add(cbxSetor.Text);
            dadoschamado.Add(cbxPrioridade.Text);
            dadoschamado.Add(txbData.Text);
            dadoschamado.Add(txbDescriçao.Text);
            Modelo.Controle controle = new Modelo.Controle();
            controle.CadastraChamado(dadoschamado);
            MessageBox.Show(controle.mensagem);
            LimparCampos();
        }
        public void LimparCampos()
        {
            txbDescriçao.Clear();
            cbxPrioridade.SelectedIndex = -1;
            cbxSetor.SelectedIndex = -1;
        }
    }
}
