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

namespace Help_Desk
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

        private void txbEntrar_Click(object sender, RoutedEventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle();
            controle.Acessar(txbUsuario.Text, txbSenha.Text);
            if(controle.mensagem.Equals(""))

            { 
                if (controle.possui)
                {
                    MessageBox.Show("logado com sucesso", "Entrando", MessageBoxButton.OK, MessageBoxImage.Information);
                    Apresentacao.frmChamado frmC = new Apresentacao.frmChamado();
                    frmLogin.Close();
                    frmC.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("login nao encontrado, verifique login e senha", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }

        }
    }
}
