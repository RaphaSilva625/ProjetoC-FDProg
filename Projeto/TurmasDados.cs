using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto;

namespace Projeto
{
    class TurmasDados
    {
        public int _turmaCodigo { get; set; }
        public string _turmaCategoria { get; set; }
        public string _turmaDias { get; set; }
        public string _turmaHorario { get; set; }
        public string _turmaProfessor { get; set; }

        public TurmasDados((int, string, string, string, string) p)
        {

        }
        public TurmasDados()
        {

        }

        public static void LerBdTurma()
        {
           
            List<TurmasDados> bdTurmas = new List<TurmasDados>();
            string arquivoDiretorio = @"E:\bdProjeto\bdTurmas.txt";
            if (File.Exists(arquivoDiretorio))
            {
                using (StreamReader arquivo = File.OpenText(arquivoDiretorio))
                {
                    string linha = "";
                    while (true)
                    {
                        linha = arquivo.ReadLine();
                        if (linha != null)
                        {
                            string[] dadosColetados = linha.Split(';');
                            bdTurmas.Add(new TurmasDados((Convert.ToInt32(dadosColetados[0]), 
                                dadosColetados[1], 
                                dadosColetados[2], 
                                dadosColetados[3], 
                                dadosColetados[4])));
                        }
                        else
                        {
                            break;
                        }
                    }
                    var menu = new Menu();
                    menu.DataGridView1.DataSource = bdTurmas;
                }      
            }
        }

        public static void CadastroTurmas()
        {
            //To do
        }

    }
}
