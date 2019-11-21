using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;


/*Metodos e funcoes utilizadas para criar, ler, editar e deletar dados.
 *Todos os metodos daqui sao utilizados em outros formularios, para melhor organizacão.
 *Os metodos, formularios, funcoes e tudo que sera utilizado, sera detalhado por meio de comentarios,
 *explicando o que foi usado, como foi usado e porque foi usado.
 *Feito, editado, organizado e pensado por Raphael Silva, como projeto final de segunda unidade da cadeira de Fundamentos da Programacão.
 *Inicio do projeto data 11/11/2019 
 *Data de termino do projeto (...)
*/
namespace Projeto3._0
{
    class BancoAcademia
    {
        public static ArrayList ListaIdAdmin = new ArrayList();
        public static ArrayList ListaSenhaAdmin = new ArrayList();

        public static void LerArquivoTurma(ArrayList codigo, ArrayList tipo, ArrayList horario, ArrayList dias, ArrayList professor)
        {
            codigo.Clear();tipo.Clear();horario.Clear();dias.Clear();professor.Clear();
            Stream diretorio = File.Open(@"E:\Projeto3.0\Projeto3.0\bdProjeto\bdTurmas.txt", FileMode.Open);
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
                professor.Add(dadosColetados[4]);
                linha = lerArquivo.ReadLine();
            }
            lerArquivo.Close();
            diretorio.Close();
        }
        public static void LerArquivoProf(ArrayList cpf, ArrayList nome, ArrayList sobrenome, ArrayList senha, ArrayList telefone, ArrayList rg,
           ArrayList genero, ArrayList nascimento, ArrayList codigoTurma)
        {
            cpf.Clear();nome.Clear();sobrenome.Clear();senha.Clear();telefone.Clear();rg.Clear();genero.Clear();nascimento.Clear();codigoTurma.Clear();
            
            Stream diretorio = File.Open(@"E:\Projeto3.0\Projeto3.0\bdProjeto\bdProfessores.txt", FileMode.Open);
            StreamReader lerArquivo = new StreamReader(diretorio);
            string linha = lerArquivo.ReadLine();
            string[] dadosColetados;
            while (linha != null)
            {
                dadosColetados = linha.Split(';');
                cpf.Add(dadosColetados[0]);
                nome.Add(dadosColetados[1]);
                sobrenome.Add(dadosColetados[2]);
                senha.Add(dadosColetados[3]);
                telefone.Add(dadosColetados[4]);
                rg.Add(dadosColetados[5]);
                genero.Add(dadosColetados[6]);
                nascimento.Add(dadosColetados[7]);
                codigoTurma.Add(dadosColetados[8]);
                linha = lerArquivo.ReadLine();
            }
            lerArquivo.Close();
            diretorio.Close();
        }
        public static void LerArquivoAdmin(ArrayList id, ArrayList senha)
        {
            id.Clear();senha.Clear();
            Stream diretorio = File.Open(@"E:\Projeto3.0\Projeto3.0\bdProjeto\bdAdmin.txt", FileMode.Open);
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
        public static void GravarArquivoTurma(ArrayList codigo, ArrayList tipo, ArrayList horario, ArrayList dias, ArrayList professor)
        {
            Stream diretorio = File.Open(@"E:\Projeto3.0\Projeto3.0\bdProjeto\bdTurmas.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(diretorio);
            {
                for (int i = 0; i < codigo.Count; i++)
                {
                    writer.WriteLine("{0};{1};{2};{3};{4}", Convert.ToString(codigo[i]),  Convert.ToString(tipo[i]),
                        Convert.ToString(horario[i]), Convert.ToString(dias[i]), Convert.ToString(professor[i]));
                }          
            }
            writer.Close();
            diretorio.Close();
        }
        public static void GravarArquivoProf(ArrayList cpf, ArrayList nome, ArrayList sobrenome, ArrayList senha
            , ArrayList telefone, ArrayList rg, ArrayList genero, ArrayList nascimento, ArrayList codigoTurma)
        {

            Stream diretorio = File.Open(@"E:\Projeto3.0\Projeto3.0\bdProjeto\bdProfessores.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(diretorio);
            {
                for (int i = 0; i < nome.Count; i++)
                {
                    writer.WriteLine("{0};{1};{2};{3};{4};{5};{6};{7};{8}", Convert.ToString(cpf[i]), Convert.ToString(nome[i]),
                        Convert.ToString(sobrenome[i]), Convert.ToString(senha[i]), 
                        Convert.ToString(telefone[i]), Convert.ToString(rg[i]),
                        Convert.ToString(genero[i]), Convert.ToString(nascimento[i]), Convert.ToString(codigoTurma[i]));
                }
            }
            writer.Close();
            diretorio.Close();
        }

        public static void NovaTurma(ArrayList ListaCodigoTurma, ArrayList ListaTipoTurma, ArrayList ListaHorarioTurma, ArrayList ListaDiasTurma, ArrayList ListaProfTurma, 
            string novoCodigo, string novoTipo, string novoHorario, string novoDia, string novoProf)
        {
            ListaCodigoTurma.Add(novoCodigo);
            ListaTipoTurma.Add(novoTipo);
            ListaHorarioTurma.Add(novoHorario);
            ListaDiasTurma.Add(novoDia);
            ListaProfTurma.Add(novoProf);
            
            BancoAcademia.GravarArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma, ListaProfTurma);
            MessageBox.Show("As aulas de " + novoTipo + " serão realizadas no(os) dia(as) de "+ novoDia +" às " + novoHorario +".", "Nova turma cadastrada", MessageBoxButtons.OK);
        }
        public static void NovoProfessor(ArrayList ListaNomeProf, ArrayList ListaSobrenomeProf,
            ArrayList ListaSenhaProf, ArrayList ListaTelefoneProf,
            ArrayList ListaCpfProf, ArrayList ListaRgProf,
            ArrayList ListaGeneroProf, ArrayList ListaNascimentoProf, ArrayList ListaCodigoTurmaProf, 
            string novoNome, string novoSobrenome, string novaSenha, string novoTelefone, 
            string novoCpf, string novoRg, string novoGenero, string novoNascimento, string novoCodigoTurma)
        {
            ListaNomeProf.Add(novoNome);
            ListaSobrenomeProf.Add(novoSobrenome);
            ListaSenhaProf.Add(novaSenha);
            ListaTelefoneProf.Add(novoTelefone);
            ListaCpfProf.Add(novoCpf);
            ListaRgProf.Add(novoRg);
            ListaGeneroProf.Add(novoGenero);
            ListaNascimentoProf.Add(novoNascimento);
            ListaCodigoTurmaProf.Add(novoCodigoTurma);
            BancoAcademia.GravarArquivoProf(ListaNomeProf, ListaSobrenomeProf, ListaSenhaProf, ListaTelefoneProf, ListaCpfProf, ListaRgProf, ListaGeneroProf, ListaNascimentoProf, ListaCodigoTurmaProf);
            MessageBox.Show("Professor " + novoNome + novoSobrenome + " foi cadastrado com sucesso", "Novo professor", MessageBoxButtons.OK);
        }

        //public static void BubbleSort(ArrayList ListaCodigoTurma)
        //{
        //    int[] vetor = (int[])ListaCodigoTurma.ToArray(typeof(int));
        //    for (int i = vetor.Length - 1; i >= 1; i--)
        //    { 
        //        for (int j = 0; j < i; j++)
        //        {
        //            if (vetor[j] > vetor[j + 1])
        //            {
        //                int aux = vetor[j];
        //                vetor[j] = vetor[j + 1];
        //                vetor[j + 1] = aux;
        //            }
        //        }
        //    }
        //}
        public static bool Autenticação(ArrayList listaDeDados, string dados)
        {           
            bool autenticador = false;
            for (int i = 0; i < listaDeDados.Count; i++)
            {
                if (dados == Convert.ToString(listaDeDados[i]))
                {
                    autenticador = true;
                    break;
                }
            }
            return autenticador;
        }
    }
}
