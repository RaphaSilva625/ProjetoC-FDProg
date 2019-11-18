using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Projeto3._0
{
    public partial class CadastroProfessores : Form
    {
        string[] genero = { "Masculino", "Feminino" };
        public static ArrayList ListaNomeProf = new ArrayList();
        public static ArrayList ListaSobrenomeProf = new ArrayList();
        public static ArrayList ListaSenhaProf = new ArrayList();
        public static ArrayList ListaTelefoneProf = new ArrayList();
        public static ArrayList ListaCpfProf = new ArrayList();
        public static ArrayList ListaRgProf = new ArrayList();
        public static ArrayList ListaGeneroProf = new ArrayList();
        public static ArrayList ListaNascimentoProf = new ArrayList();
        
        public CadastroProfessores()
        {
            InitializeComponent();           
        }

        private void CadastroProfessores_Load(object sender, EventArgs e)
        {
            BancoAcademia.LerArquivoProf(ListaNomeProf, ListaSobrenomeProf, ListaSenhaProf, ListaTelefoneProf, ListaCpfProf, ListaRgProf, ListaGeneroProf, ListaNascimentoProf);
            foreach (string gen in genero)
            {
                cbxGeneroProf.Items.Add(gen);
            }
        }

        private void BtnCancelarProf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSalvarProf_Click(object sender, EventArgs e)
        {
            string novoNome = txtNovoNome.Text;
            string novoSobrenome = txtNovoSobrenome.Text;
            string novaSenha = txtNovaSenha.Text;
            string novoTelefone = mtxtNovoTelefone.Text;
            string novoCpf = mtxtNovoCpf.Text;
            string novoRg = txtNovoRg.Text;
            string novoGenero = cbxGeneroProf.Text;
            string novoNascimento = mtxtNovoData.Text;

            if (!BancoAcademia.Autenticação(ListaCpfProf, novoCpf))
            {
                if (!BancoAcademia.Autenticação(ListaRgProf, novoRg))
                {
                    BancoAcademia.NovoProfessor(ListaNomeProf, ListaSobrenomeProf, ListaSenhaProf, ListaTelefoneProf, ListaCpfProf, ListaRgProf, ListaGeneroProf, ListaNascimentoProf, 
                        novoNome, novoSobrenome, novaSenha, novoTelefone, novoCpf, novoRg, novoGenero, novoNascimento);
                }
                else
                {
                    MessageBox.Show("Já existe um usuario com este RG cadastrado. Por favor verifique o campo RG e tente novamente.", "Erro", MessageBoxButtons.OK);
                }
                    
            }
            else
            {
                MessageBox.Show("Já existe um usuário com este CPF cadastrado. Por favor verifique o campo CPF e tente novamente", "Erro", MessageBoxButtons.OK);
            }

        }
    }
}
