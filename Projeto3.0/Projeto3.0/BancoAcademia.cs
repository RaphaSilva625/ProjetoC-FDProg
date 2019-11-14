using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3._0
{
    class BancoAcademia
    {
        
        public List<string> ListaCodigoTurma = new List<string>();
        public List<string> ListaHorarioTurma = new List<string>();
        public List<string> ListaDiasTurma = new List<string>();
        public List<string> ListaTipoTurma = new List<string>(); 

        public string CodigoTurma()
        {
            string codigo;
            codigo = "00" + ListaCodigoTurma.Count + 1;
            return codigo;
        }

        public void AttLista()
        {
            StreamReader sw = new StreamReader(@"E:\bdProjeto\bdTurmas.txt", true);
            string linha;
            string[] dadosColetados;
            while (((linha = sw.ReadLine()) != null))
            {
                dadosColetados = linha.Split(';');
                ListaCodigoTurma.Add(dadosColetados[0]);
                ListaHorarioTurma.Add(dadosColetados[1]);
                ListaDiasTurma.Add(dadosColetados[2]);
                ListaTipoTurma.Add(dadosColetados[3]);
            }
            sw.Close();
        }
    }
}
