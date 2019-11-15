using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;


/*Metodos e funcoes utilizadas para criar, ler, editar e deletar dados.
 *Todos os metdos daqui sao utilizados em outros formularios, para melhor organizacao.
 *Os metodos, formularios, funcoes e tudo que sera utilizado, sera detalhado por meio de comentarios,
 *explicando o que foi usado, como foi usado e porque foi usado.
 *Feito, editado, organizado e pensado por Raphael Silva, como projeto final de segunda unidade da cadeira de Fundamentos da Prgramacao.
 *Inicio do projeto data 11/11/2019 
 *Data de termino do projeto (...)
*/
namespace Projeto3._0
{
    class BancoAcademia
    {
        public static ArrayList ListaIdAdmin = new ArrayList();
        public static ArrayList ListaSenhaAdmin = new ArrayList();

        public static void LerArquivoTurma(ArrayList codigo, ArrayList tipo, ArrayList horario, ArrayList dias)
        {
            Stream diretorio = File.Open(@"E:\bdProjeto\bdTurmas.txt", FileMode.Open);
            StreamReader lerArquivo = new StreamReader(diretorio);
            string linha = lerArquivo.ReadLine();
            string[] dadosColetados;
            while (linha != null)
            {
                dadosColetados = linha.Split(';');
                codigo.Add(dadosColetados[0]);
                tipo.Add(dadosColetados[1]);
                horario.Add(dadosColetados[2]);
                dias.Add(dadosColetados[3]);
                linha = lerArquivo.ReadLine();
            }
            lerArquivo.Close();
            diretorio.Close();
        }
        public static void LerArquivoProf(ArrayList nome, ArrayList sobrenome, ArrayList telefone, ArrayList nascimento, ArrayList rg,
           ArrayList cpf, ArrayList genero)
        {
            Stream diretorio = File.Open(@"E:\bdProjeto\bdProfessores.txt", FileMode.Open);
            StreamReader lerArquivo = new StreamReader(diretorio);
            string linha = lerArquivo.ReadLine();
            string[] dadosColetados;
            while (linha != null)
            {
                dadosColetados = linha.Split(';');
                nome.Add(dadosColetados[0]);
                sobrenome.Add(dadosColetados[1]);
                telefone.Add(dadosColetados[2]);
                nascimento.Add(dadosColetados[3]);
                rg.Add(dadosColetados[3]);
                cpf.Add(dadosColetados[3]);
                genero.Add(dadosColetados[3]);
                linha = lerArquivo.ReadLine();
            }
            lerArquivo.Close();
            diretorio.Close();
        }
        public static void LerArquivoAdmin(ArrayList id, ArrayList senha)
        {
            Stream diretorio = File.Open(@"E:\bdProjeto\bdAdmin.txt", FileMode.Open);
            StreamReader lerArquivo = new StreamReader(diretorio);
            string linha = lerArquivo.ReadLine();
            string[] dadosColetados;
            while (linha != null)
            {
                dadosColetados = linha.Split(';');
                id.Add(dadosColetados[0]);
                senha.Add(dadosColetados[1]);
                linha = lerArquivo.ReadLine();
            }
            lerArquivo.Close();
            diretorio.Close();
        }
        public static bool Autenticação(ArrayList listaDeDados, string dados)
        {
            BancoAcademia.LerArquivoAdmin(ListaIdAdmin, ListaSenhaAdmin);
            bool testeDeSenhas = false;
            for (int i = 0; i < listaDeDados.Count; i++)
            {
                if (dados == Convert.ToString(listaDeDados[i]))
                {
                    testeDeSenhas = true;
                }                
            }
            return testeDeSenhas;
        }
        public static void GravarArquivo(ArrayList codigo, ArrayList tipo, ArrayList horario, ArrayList dias)
        {

            Stream diretorio = File.Open(@"E:\bdProjeto\bdTurmas.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(diretorio);
            {
                for (int i = 0; i < codigo.Count; i++)
                {
                    writer.WriteLine("{0};{1};{2};{3}", Convert.ToString(codigo[i]),  Convert.ToString(tipo[i]), Convert.ToString(horario[i]), Convert.ToString(dias[i]));
                }          
            }
            writer.Close();
            diretorio.Close();
        }
        public static void NovaTurma(ArrayList ListaCodigoTurma, ArrayList ListaTipoTurma, ArrayList ListaHorarioTurma, ArrayList ListaDiasTurma, 
            string novoCodigo, string novoTipo, string novoHorario, string novoDia)
        {
            ListaCodigoTurma.Add(novoCodigo);
            ListaTipoTurma.Add(novoTipo);
            ListaHorarioTurma.Add(novoHorario);
            ListaDiasTurma.Add(novoDia);
            
            BancoAcademia.GravarArquivo(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma);
            MessageBox.Show("As aulas de " + novoTipo + " serão realizadas no(os) dia(as) de "+ novoDia +" às " + novoHorario +".", "Nova turma cadastrada", MessageBoxButtons.OK);
        }
       
        
    }
}
