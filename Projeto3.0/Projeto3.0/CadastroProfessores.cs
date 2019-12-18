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
            txtNomeTurma.Enabled = false;
            BancoAcademia.LerArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma);
            BancoAcademia.LerArquivoProf(ListaCpfProf, ListaNomeProf, ListaSobrenomeProf, ListaSenhaProf, ListaTelefoneProf, ListaRgProf, ListaGeneroProf, ListaNascimentoProf, ListaCodigoTurmaProf);
            foreach (string gen in genero)
            {
                cbxGeneroProf.Items.Add(gen);
            }
            foreach (string turma in ListaCodigoTurma)
            {
                cbxTurmasOn.Items.Add(turma);
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
            string novoCodigoTurma;

            #region Tratamento de codigo
            if (cbxTurmasOn.Text != "[Selecione]")
            {
                novoCodigoTurma = cbxTurmasOn.SelectedItem.ToString();
                
            }
            else
            {
                MessageBox.Show("O campo turma é obrigatorio.", "Erro", MessageBoxButtons.OK);
                cbxTurmasOn.Focus();
                return;
            }
            #endregion
            #region Tratamento de genero
            if (cbxGeneroProf.Text == "[Selecione]")
            {
                MessageBox.Show("O campo genero é obrigatório.", "Erro", MessageBoxButtons.OK);
                cbxGeneroProf.Focus();
                return;
            }
            #endregion
            #region Tratamento de Senha
            if (novaSenha.Length < 4)
            {
                MessageBox.Show("Digite uma senha com mais de 4 caracteres.", "Erro", MessageBoxButtons.OK);
                txtNovaSenha.Focus();
                return;
            }
            #endregion
            #region Tratamento CPF
            if (novoCpf.Length != 11)
            {
                MessageBox.Show("O campo CPF requer onze números.", "Erro", MessageBoxButtons.OK);
                txtNovoCpf.Focus();
                return;
            }
            try
            {
                Convert.ToInt64(novoCpf);
            }
            catch 
            {
                MessageBox.Show("Digite apenas números!!", "Erro", MessageBoxButtons.OK);
                txtNovoCpf.Focus();
                return;
            }
            if (BancoAcademia.Autenticação(ListaCpfProf, novoCpf))
            {
                MessageBox.Show("Já existe um usuário com este CPF cadastrado. Por favor verifique o campo CPF e tente novamente", "Erro", MessageBoxButtons.OK);
                txtNovoCpf.Focus();
                return;
            }
            #endregion
            #region Tratamento RG
            if (novoRg.Length != 7)
            {
                MessageBox.Show("O campo RG requer sete números.", "Erro", MessageBoxButtons.OK);
                txtNovoRg.Focus();
                return;
            }
            try
            {
                Convert.ToInt32(novoRg);
            }
            catch
            {
                MessageBox.Show("Digite apenas números!!", "Erro", MessageBoxButtons.OK);
                txtNovoRg.Focus();
                return;
            }
            if (BancoAcademia.Autenticação(ListaRgProf, novoRg))
            {
                MessageBox.Show("Já existe um usuario com este RG cadastrado. Por favor verifique o campo RG e tente novamente.", "Erro", MessageBoxButtons.OK);
                txtNovoRg.Focus();
                return;
            }
            #endregion
            #region Tratamento do Nome
            string novoNomeTeste = novoNome.ToUpper();
            if (novoNomeTeste.Length <= 2)
            {
                MessageBox.Show("Digite seu primeiro nome inteiro, sem abreviações ou apelidos.", "Erro", MessageBoxButtons.OK);
                txtNovoNome.Focus();
                return;
            }
            for (int i = 0; i < novoNomeTeste.Length; i++)
            {
                if (String.Compare(novoNomeTeste.Substring(i, 1), "A") < 0 || String.Compare(novoNomeTeste.Substring(i, 1), "Z") > 0)
                {
                    MessageBox.Show("Digite apenas letras!", "Erro", MessageBoxButtons.OK);
                    txtNovoNome.Focus();
                    return;
                }
            }
            #endregion
            #region Tratamento do Sobrenome
            string novoSobrenomeTeste = novoSobrenome.ToUpper();
            if (novoSobrenomeTeste.Length <= 2)
            {
                MessageBox.Show("Digite seu sobrenome inteiro, sem abreviações ou apelidos.", "Erro", MessageBoxButtons.OK);
                txtNovoSobrenome.Focus();
                return;
            }
            for (int i = 0; i < novoSobrenomeTeste.Length; i++)
            {
                if (String.Compare(novoSobrenomeTeste.Substring(i, 1), "A") < 0 || String.Compare(novoSobrenomeTeste.Substring(i, 1), "Z") > 0)
                {
                    MessageBox.Show("Digite apenas letras!", "Erro", MessageBoxButtons.OK);
                    txtNovoSobrenome.Focus();
                    return;
                }
            }
            #endregion
            #region Tratamento de telefone
            if (novoTelefone.Length != 11)
            {
                MessageBox.Show("O campo telefone requer 11 números.", "Erro", MessageBoxButtons.OK);
                mtxtNovoTelefone.Focus();
                return;
            }
            try
            {
                Convert.ToInt64(novoTelefone);
            }
            catch
            {
                MessageBox.Show("Digite apenas números!!", "Erro", MessageBoxButtons.OK);
                mtxtNovoTelefone.Focus();
                return;
            }
            #endregion
            #region Tratamento de data
            if (novoNascimento.Length == 8)
            {
                int dataDia = 0;
                int dataMes = 0;
                int dataAno = 0;
                int anoAtual = DateTime.Now.Year;
                int mesAtual = DateTime.Now.Month;
                int diaAtual = DateTime.Now.Day;             
                try
                {
                    dataDia = Convert.ToInt32(novoNascimento.Substring(0, 2));
                    dataMes = Convert.ToInt32(novoNascimento.Substring(2, 2));
                    dataAno = Convert.ToInt32(novoNascimento.Substring(4, 4));
                }
                catch
                {
                    MessageBox.Show("Digite apenas números.", "Erro", MessageBoxButtons.OK);
                    mtxtNovoData.Focus();
                    return;
                }
                if (dataDia < 01 || dataDia > 31)
                {
                    MessageBox.Show("Digite valores entre 1 e 31 no campo dias!", "Erro", MessageBoxButtons.OK);
                    mtxtNovoData.Focus();
                    return;
                }
                else if (dataMes < 01 || dataMes > 12)
                {
                    MessageBox.Show("Digite valores entre 1 e 12 no campo mês!", "Erro", MessageBoxButtons.OK);
                    mtxtNovoData.Focus();
                    return;
                }
                else if (dataAno < 1985 || dataAno > anoAtual)
                {
                    MessageBox.Show("Ano invalido, digite valores entre 1985 e " + anoAtual + " !", "Erro", MessageBoxButtons.OK);
                    mtxtNovoData.Focus();
                    return;
                }
                else if (dataAno == anoAtual)
                {
                    if (dataMes > mesAtual)
                    {
                        MessageBox.Show("Esta mês está em um intervalo de tempo inválido, verifique o campo e tente novamente.", "Erro", MessageBoxButtons.OK);
                        mtxtNovoData.Focus();
                        return;                        
                    }
                    else if (dataMes == mesAtual)
                    {
                        if (dataDia > diaAtual)
                        {
                            MessageBox.Show("Esta dia está em um intervalo de tempo inválido, verifique o campo e tente novamente.", "Erro", MessageBoxButtons.OK);
                            mtxtNovoData.Focus();
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Data de nascimento inválido, digite no formato DD/MM/AAAA.", "Erro", MessageBoxButtons.OK);
                mtxtNovoData.Focus();
                return;
            }
            #endregion 
            BancoAcademia.GravarArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma);
            BancoAcademia.NovoProfessor(ListaCpfProf, ListaNomeProf, ListaSobrenomeProf, ListaSenhaProf, ListaTelefoneProf, ListaRgProf, ListaGeneroProf, ListaNascimentoProf, ListaCodigoTurmaProf,
                        novoCpf, novoNome, novoSobrenome, novaSenha, novoTelefone, novoRg, novoGenero, novoNascimento, novoCodigoTurma);
            this.Close();
        }

        private void CbxTurmasOn_SelectedIndexChanged(object sender, EventArgs e)
        {            
            for (int i = 0; i < ListaCodigoTurma.Count; i++)
            {
                if (cbxTurmasOn.SelectedItem.ToString() == ListaCodigoTurma[i].ToString())
                {
                    txtNomeTurma.Text = ListaTipoTurma[i].ToString();
                    break;
                }               
            }
        }

        private void cckSenhaProf_CheckedChanged(object sender, EventArgs e)
        {
            if (cckSenhaProf.Checked)
            {
                txtNovaSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtNovaSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
