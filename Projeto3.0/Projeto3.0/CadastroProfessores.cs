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
        public static ArrayList ListaCodigoTurmaProf = new ArrayList();

        public static ArrayList ListaCodigoTurma = new ArrayList();
        public static ArrayList ListaTipoTurma = new ArrayList();
        public static ArrayList ListaHorarioTurma = new ArrayList();
        public static ArrayList ListaDiasTurma = new ArrayList();
        public static ArrayList ListaProfTurma = new ArrayList();

        public CadastroProfessores()
        {
            InitializeComponent();           
        }

        private void CadastroProfessores_Load(object sender, EventArgs e)
        {
            BancoAcademia.LerArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma, ListaProfTurma);
            BancoAcademia.LerArquivoProf(ListaNomeProf, ListaSobrenomeProf, ListaSenhaProf, ListaTelefoneProf, ListaCpfProf, ListaRgProf, ListaGeneroProf, ListaNascimentoProf, ListaCodigoTurmaProf);
            foreach (string gen in genero)
            {
                cbxGeneroProf.Items.Add(gen);
            }
            foreach (var item in ListaCodigoTurma)
            {
                cbxTurmasOn.Items.Add(item);
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
            string novoCpf = txtNovoCpf.Text;
            string novoRg = txtNovoRg.Text;
            string novoGenero = cbxGeneroProf.Text;
            string novoNascimento = mtxtNovoData.Text;
            string novoCodigoTurma = cbxTurmasOn.Text;

            if (!BancoAcademia.Autenticação(ListaCpfProf, novoCpf))
            {
                if (!BancoAcademia.Autenticação(ListaRgProf, novoRg))
                {
                    BancoAcademia.NovoProfessor(ListaCpfProf, ListaNomeProf, ListaSobrenomeProf, ListaSenhaProf, ListaTelefoneProf, ListaRgProf, ListaGeneroProf, ListaNascimentoProf, ListaCodigoTurmaProf, 
                        novoCpf, novoNome, novoSobrenome, novaSenha, novoTelefone, novoRg, novoGenero, novoNascimento, novoCodigoTurma);
                }
                else
                {
                    MessageBox.Show("Já existe um usuario com este RG cadastrado. Por favor verifique o campo RG e tente novamente.", "Erro", MessageBoxButtons.OK);
                    txtNovoRg.Focus();
                }
                    
            }
            else
            {
                MessageBox.Show("Já existe um usuário com este CPF cadastrado. Por favor verifique o campo CPF e tente novamente", "Erro", MessageBoxButtons.OK);
                txtNovoCpf.Focus();
            }

        }
    }
}
