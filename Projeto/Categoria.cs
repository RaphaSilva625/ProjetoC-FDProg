using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto.Cadastros;

namespace Projeto
{
    class Categoria
    {
        public int codigoCategoria;
        public string nomeCategoria;

        public static void LerCategorias()
        {
            List<Categoria> lerBdCategoria = new List<Categoria>();
            string arquivoDiretorio = @"E:\bdProjeto\bdCategoria.txt";
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
                            lerBdCategoria.Add(new Categoria
                            {
                                codigoCategoria = Convert.ToInt32(dadosColetados[0]),
                                nomeCategoria = dadosColetados[1]
                            });
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
