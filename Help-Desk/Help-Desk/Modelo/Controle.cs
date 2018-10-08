using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Help_Desk.DAL;

namespace Help_Desk.Modelo
{
    public class Controle
    {
        public String mensagem;
        public bool possui;

        public bool Acessar(String login, String senha)
        {
            this.mensagem = "";
            ChamadoDAO chamadoDAO = new ChamadoDAO();
            possui = chamadoDAO.VerificarLogin(login, senha);

            if (!chamadoDAO.mensagem.Equals(""))
            {
                this.mensagem = chamadoDAO.mensagem;
            }
            return possui;
        }

        public Chamado PesquisaSolicitantePorID(int id_Usuario)
        {
            Chamado chamado = new Chamado();
            ChamadoDAO chamadoDAO = new ChamadoDAO();
            chamadoDAO.PesquisaSolicitantePorID(chamado);

            return chamado;
        }

            

        public void CadastraChamado(List<String> dadoschamado)
        {
            this.mensagem = "";
            Validacao validacao = new Validacao();
            validacao.ValidarDadosChamado(dadoschamado);
            if (validacao.mensagem.Equals(""))
            {
                Chamado chamado = new Chamado();
                chamado.usuario = dadoschamado[1];
                chamado.setor = dadoschamado[2];
                chamado.prioridade = dadoschamado[3];
                chamado.descricao = dadoschamado[4];

                //chamado.data = dadoschamado[5];

                
                DAL.ChamadoDAO chamadoDAO = new DAL.ChamadoDAO();
                chamadoDAO.CadastraChamado(chamado);
                this.mensagem = chamadoDAO.mensagem;
            }
            else
            {
                this.mensagem = validacao.mensagem;
            }
        }
    }
}
