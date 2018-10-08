using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Help_Desk.Modelo;

namespace Help_Desk.DAL
{
    interface intChamadoDAO
    {
        void CadastraChamado(Chamado chamado);
        Chamado PesquisaChamadoPorId(Chamado chamado);
        void EditarChamado(Chamado chamado);
        void ExcluirChamado(Chamado chamado);
        bool VerificarLogin(String login, String senha);
        Chamado PesquisaSolicitantePorID(Chamado chamado);

        // List<chamado> PesquisarChamadoPorPrioridade(Chamado chamado);
    }
}
