using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto3._0
{
    public partial class MenuProfessores : Form
    {
        string[] genero = { "Masculino", "Feminino" };
        public static ArrayList ListaNomeProf = new ArrayList();
        public static ArrayList ListaSobrenomeProf = new ArrayList();
        public static ArrayList ListaSenhaProf = new ArrayList();
        public static ArrayList ListaTelefoneProf = new ArrayList();
        public static ArrayList ListaCpfProf = new ArrayList();
        public static ArrayList ListaRgProf = new ArrayList();
        public static ArrayList ListaGeneroProf = new ArrayList();
        public static ArrayList ListaDataProf = new ArrayList();
        public static ArrayList ListaCodigoTurmaProf = new ArrayList();

        public static ArrayList ListaCodigoTurma = new ArrayList();
        public static ArrayList ListaTipoTurma = new ArrayList();
        public static ArrayList ListaHorarioTurma = new ArrayList();
        public static ArrayList ListaDiasTurma = new ArrayList();

        public MenuProfessores()
        {
            InitializeComponent();
        }

        private void MenuProfessores_Load(object sender, EventArgs e)
        {
            txtNomeProf.Enabled = false;
            txtSobrenomeProf.Enabled = false;
            txtSenhaProf.Enabled = false;
            mtxtTelefoneProf.Enabled = false;
            txtCpfProf.Enabled = false;
            txtRgProf.Enabled = false;
            cbxGeneroProf.Enabled = false;
            mtxtDataProf.Enabled = false;
            cbxCodigoTurma.Enabled = false;
            btnSalvarEditProf.Enabled = false;
            btnSalvarEditProf.Visible = false;
            cckSenhaProf.Enabled = false;
            btnDeleteProf.Enabled = false;
            btnEditProf.Enabled = false;

            lvProf.Columns.Add("CPF", 80);
            lvProf.Columns.Add("Nome", 75);
            lvProf.Columns.Add("Sobrenome", 65);
            lvProf.Columns.Add("Telefone", 75);
            lvProf.Columns.Add("RG", 65);
            lvProf.Columns.Add("Genero", 75);
            lvProf.Columns.Add("Data", 75);
            lvProf.Columns.Add("Tipo", 50);
        }

        private void BtnListarProf_Click(object sender, EventArgs e)
        {
            BancoAcademia.LerArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma);
            BancoAcademia.LerArquivoProf(ListaCpfProf, ListaNomeProf, ListaSobrenomeProf, ListaSenhaProf, ListaTelefoneProf, ListaRgProf, ListaGeneroProf, ListaDataProf, ListaCodigoTurmaProf);
            if (ListaCpfProf.Count == 0)
            {
                DialogResult resposta;
                resposta = MessageBox.Show("Não há professores cadastrados, deseja cadastrar um novo professor?", "Erro", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    new CadastroProfessores().Show();
                }
            }
            lvProf.Items.Clear();
            string[] dadosProf = new string[8];
            ListViewItem prof;
            for (int i = 0; i < ListaCpfProf.Count; i++)
            {
                dadosProf[0] = ListaCpfProf[i].ToString();
                dadosProf[1] = ListaNomeProf[i].ToString();
                dadosProf[2] = ListaSobrenomeProf[i].ToString();
                dadosProf[3] = ListaTelefoneProf[i].ToString();
                dadosProf[4] = ListaRgProf[i].ToString();
                dadosProf[5] = ListaGeneroProf[i].ToString();
                dadosProf[6] = ListaDataProf[i].ToString();
                if (ListaCodigoTurma.Count != 0)
                {
                    for (int j = 0; j < ListaCodigoTurma.Count; j++)
                    {
                        if (ListaCodigoTurmaProf[i].ToString() == ListaCodigoTurma[j].ToString())
                        {
                            dadosProf[7] = ListaTipoTurma[j].ToString();
                            break;
                        }
                        else
                        {
                            dadosProf[7] = ListaCodigoTurmaProf[i].ToString();
                        }
                    }
                }
                else
                {
                    dadosProf[7] = ListaCodigoTurmaProf[i].ToString();
                }
                prof = new ListViewItem(dadosProf);
                lvProf.Items.Add(prof);
            }
        }

        private void LvProf_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            for (int i = 0; i < ListaCpfProf.Count; i++)
            {
                if (lvProf.FocusedItem.Text == ListaCpfProf[i].ToString())
                {
                    txtNomeProf.Text = ListaNomeProf[i].ToString();
                    txtSobrenomeProf.Text = ListaSobrenomeProf[i].ToString();
                    txtSenhaProf.Text = ListaSenhaProf[i].ToString();
                    mtxtTelefoneProf.Text = ListaTelefoneProf[i].ToString();
                    cbxCodigoTurma.Text = ListaCodigoTurmaProf[i].ToString();
                    cbxGeneroProf.Text = ListaGeneroProf[i].ToString();
                    txtCpfProf.Text = ListaCpfProf[i].ToString();
                    txtRgProf.Text = ListaRgProf[i].ToString();
                    mtxtDataProf.Text = ListaDataProf[i].ToString();
                    break;
                }
            }
            btnEditProf.Enabled = true;
            btnDeleteProf.Enabled = true;
            BancoAcademia.LerArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma);
            foreach (string genero in genero)
            {
                cbxGeneroProf.Items.Add(genero);
            }
            cbxCodigoTurma.Items.Clear();
            foreach (string codigo in ListaCodigoTurma)
            {
                cbxCodigoTurma.Items.Add(codigo);
            }
        }

        private void CckSenhaProf_CheckedChanged(object sender, EventArgs e)
        {
            if (cckSenhaProf.Checked)
            {
                txtSenhaProf.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenhaProf.UseSystemPasswordChar = true;
            }
        }

        private void BtnEditProf_Click(object sender, EventArgs e)
        {
            txtNomeProf.Enabled = true;
            txtSobrenomeProf.Enabled = true;
            txtSenhaProf.Enabled = true;
            cbxGeneroProf.Enabled = true;
            mtxtDataProf.Enabled = true;
            mtxtTelefoneProf.Enabled = true;
            cbxCodigoTurma.Enabled = true;
            cckSenhaProf.Enabled = true;
            btnSalvarEditProf.Enabled = true;
            btnSalvarEditProf.Visible = true;
        }

        private void BtnSalvarEditProf_Click(object sender, EventArgs e)
        {
            #region Tratamento de genero
            if (cbxGeneroProf.Text == "[Selecione]")
            {
                MessageBox.Show("O campo genero é obrigatório.", "Erro", MessageBoxButtons.OK);
                cbxGeneroProf.Focus();
                return;
            }
            #endregion
            #region Tratamento de Senha
            if (txtSenhaProf.TextLength < 4)
            {
                MessageBox.Show("Digite uma senha com mais de 4 caracteres.", "Erro", MessageBoxButtons.OK);
                txtSenhaProf.Focus();
                return;
            }
            #endregion
            #region Tratamento do Nome
            string novoNomeTeste = txtNomeProf.Text.ToUpper();
            if (novoNomeTeste.Length <= 2)
            {
                MessageBox.Show("Digite seu primeiro nome inteiro, sem abreviações ou apelidos.", "Erro", MessageBoxButtons.OK);
                txtNomeProf.Focus();
                return;
            }
            for (int i = 0; i < novoNomeTeste.Length; i++)
            {
                if (String.Compare(novoNomeTeste.Substring(i, 1), "A") < 0 || String.Compare(novoNomeTeste.Substring(i, 1), "Z") > 0)
                {
                    MessageBox.Show("O campo nome é exclusivo para letras.", "Erro", MessageBoxButtons.OK);
                    txtNomeProf.Focus();
                    return;
                }
            }
            #endregion
            #region Tratamento do Sobrenome
            string novoSobrenomeTeste = txtSobrenomeProf.Text.ToUpper();
            if (novoSobrenomeTeste.Length <= 2)
            {
                MessageBox.Show("Digite seu sobrenome inteiro, sem abreviações ou apelidos.", "Erro", MessageBoxButtons.OK);
                txtSobrenomeProf.Focus();
                return;
            }
            for (int i = 0; i < novoSobrenomeTeste.Length; i++)
            {
                if (String.Compare(novoSobrenomeTeste.Substring(i, 1), "A") < 0 || String.Compare(novoSobrenomeTeste.Substring(i, 1), "Z") > 0)
                {
                    MessageBox.Show("O campo sobrenome é exclusivo para letras.", "Erro", MessageBoxButtons.OK);
                    txtSobrenomeProf.Focus();
                    return;
                }
            }
            #endregion
            #region Tratamento de telefone
            if (mtxtTelefoneProf.Text.Length != 11)
            {
                MessageBox.Show("O campo telefone requer 11 números.", "Erro", MessageBoxButtons.OK);
                mtxtTelefoneProf.Focus();
                return;
            }
            try
            {
                Convert.ToInt64(mtxtTelefoneProf.Text);
            }
            catch
            {
                MessageBox.Show("Digite apenas números!!", "Erro", MessageBoxButtons.OK);
                mtxtTelefoneProf.Focus();
                return;
            }
            #endregion
            #region Tratamento de data
            string novaData = mtxtDataProf.Text;
            if (novaData.Length == 8)
            {
                int dataDia = 0;
                int dataMes = 0;
                int dataAno = 0;
                int anoAtual = DateTime.Now.Year;
                int mesAtual = DateTime.Now.Month;
                int diaAtual = DateTime.Now.Day;
                try
                {
                    dataDia = Convert.ToInt32(novaData.Substring(0, 2));
                    dataMes = Convert.ToInt32(novaData.Substring(2, 2));
                    dataAno = Convert.ToInt32(novaData.Substring(4, 4));
                }
                catch
                {
                    MessageBox.Show("Digite apenas números.", "Erro", MessageBoxButtons.OK);
                    mtxtDataProf.Focus();
                    return;
                }
                if (dataDia < 01 || dataDia > 31)
                {
                    MessageBox.Show("Digite valores entre 1 e 31 no campo dias!", "Erro", MessageBoxButtons.OK);
                    mtxtDataProf.Focus();
                    return;
                }
                else if (dataMes < 01 || dataMes > 12)
                {
                    MessageBox.Show("Digite valores entre 1 e 12 no campo mês!", "Erro", MessageBoxButtons.OK);
                    mtxtDataProf.Focus();
                    return;
                }
                else if (dataAno < 1985 || dataAno > anoAtual)
                {
                    MessageBox.Show("Ano invalido, digite valores entre 1985 e " + anoAtual + " !", "Erro", MessageBoxButtons.OK);
                    mtxtDataProf.Focus();
                    return;
                }
                else if (dataAno == anoAtual)
                {
                    if (dataMes > mesAtual)
                    {
                        MessageBox.Show("Esta mês está em um intervalo de tempo inválido, verifique o campo e tente novamente.", "Erro", MessageBoxButtons.OK);
                        mtxtDataProf.Focus();
                        return;
                    }
                    else if (dataMes == mesAtual)
                    {
                        if (dataDia > diaAtual)
                        {
                            MessageBox.Show("Esta dia está em um intervalo de tempo inválido, verifique o campo e tente novamente.", "Erro", MessageBoxButtons.OK);
                            mtxtDataProf.Focus();
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Data de nascimento inválido, digite no formato DD/MM/AAAA.", "Erro", MessageBoxButtons.OK);
                mtxtDataProf.Focus();
                return;
            }
            #endregion 
            for (int i = 0; i < ListaCodigoTurma.Count; i++)
            {
                if (txtCpfProf.Text == ListaCpfProf[i].ToString())
                {
                    ListaNomeProf[i] = txtNomeProf.Text;
                    ListaSobrenomeProf[i] = txtSobrenomeProf.Text;
                    ListaSenhaProf[i] = txtSenhaProf.Text;
                    ListaDataProf[i] = mtxtDataProf.Text;
                    ListaGeneroProf[i] = cbxGeneroProf.Text;
                    ListaTelefoneProf[i] = mtxtTelefoneProf.Text;
                    ListaCodigoTurmaProf[i] = cbxCodigoTurma.Text;
                    break;
                }
            }

            BancoAcademia.GravarArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma);
            BancoAcademia.GravarArquivoProf(ListaCpfProf, ListaNomeProf, ListaSobrenomeProf, ListaSenhaProf, ListaTelefoneProf, ListaRgProf, ListaGeneroProf, ListaDataProf, ListaCodigoTurmaProf);
            MessageBox.Show("Informações atualizadas com sucesso, clique listar para detalhes.", "Atenção", MessageBoxButtons.OK);
            txtNomeProf.Clear(); txtSobrenomeProf.Clear(); txtSenhaProf.Clear(); mtxtTelefoneProf.Clear();cbxCodigoTurma.Items.Clear();txtCpfProf.Clear();txtRgProf.Clear();cbxGeneroProf.Items.Clear();mtxtDataProf.Clear();
            txtNomeProf.Enabled = false;
            txtSobrenomeProf.Enabled = false;
            txtSenhaProf.Enabled = false;
            mtxtTelefoneProf.Enabled = false;
            txtCpfProf.Enabled = false;
            txtRgProf.Enabled = false;
            cbxGeneroProf.Enabled = false;
            mtxtDataProf.Enabled = false;
            cbxCodigoTurma.Enabled = false;
            btnSalvarEditProf.Enabled = false;
            btnSalvarEditProf.Visible = false;
            cckSenhaProf.Enabled = false;
            btnDeleteProf.Enabled = false;
            btnEditProf.Enabled = false;
        }

        private void BtnDeleteProf_Click(object sender, EventArgs e)
        {
            string nome = txtNomeProf.Text;
            DialogResult resposta;
            resposta = MessageBox.Show("Você deseja excluir o professor " + nome + " do sistema?", "Aviso", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                for (int i = 0; i < ListaCpfProf.Count; i++)
                {
                    if (txtCpfProf.Text == ListaCpfProf[i].ToString())
                    {
                        ListaCpfProf.Remove(ListaCpfProf[i]);
                        ListaNomeProf.Remove(ListaNomeProf[i]);
                        ListaSobrenomeProf.Remove(ListaSobrenomeProf[i]);
                        ListaSenhaProf.Remove(ListaSenhaProf[i]);
                        ListaTelefoneProf.Remove(ListaTelefoneProf[i]);
                        ListaRgProf.Remove(ListaRgProf[i]);
                        ListaDataProf.Remove(ListaDataProf[i]);
                        ListaGeneroProf.Remove(ListaGeneroProf[i]);
                        ListaCodigoTurmaProf.Remove(ListaCodigoTurmaProf[i]);
                        break;
                    }
                }
            }
            MessageBox.Show("Cadastro removido com sucesso!!", "Aviso", MessageBoxButtons.OK);
            BancoAcademia.GravarArquivoProf(ListaCpfProf, ListaNomeProf, ListaSobrenomeProf, ListaSenhaProf, ListaTelefoneProf, ListaRgProf, ListaGeneroProf, ListaDataProf, ListaCodigoTurmaProf);
        }
    }
}
