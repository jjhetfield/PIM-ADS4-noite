using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Help_Desk.Modelo
{
    public class Validacao
    {
        public String mensagem;
        public int id;

        public void ValidarDadosChamado (List<String> dadoschamado)
        {
            this.mensagem = "";
            if (dadoschamado[4].Length > 255)
                this.mensagem = "A quantidade de caracteres no campo descrição foi excedida";
            
            try
            {
                this.id = Convert.ToInt32(dadoschamado[0]);
            }
            catch (FormatException e)
            {
                this.mensagem += "ID invalido";

            }
        }
    }
}
