using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto3._0
{
    public partial class TelaLogin : Form
    {
        //Lista de dados do professor
        #region 
        public static ArrayList ListaNomeProf = new ArrayList();
        public static ArrayList ListaSobrenomeProf = new ArrayList();
        public static ArrayList ListaSenhaProf = new ArrayList();
        public static ArrayList ListaTelefoneProf = new ArrayList();
        public static ArrayList ListaNascimentoProf = new ArrayList();
        public static ArrayList ListaRgProf = new ArrayList();
        public static ArrayList ListaCpfProf = new ArrayList();
        public static ArrayList ListaGeneroProf = new ArrayList();
        public static ArrayList ListaCodigoTurmaProf = new ArrayList();
        #endregion
        //Lista de dados do Admin
        #region
        public static ArrayList ListaIdAdmin = new ArrayList();
        public static ArrayList ListaSenhaAdmin = new ArrayList();
        #endregion

        string[] loginSelecao = { "Admin", "Professor" };

        public TelaLogin()
        {
            InitializeComponent();         
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            BancoAcademia.LerArquivoAdmin(ListaIdAdmin, ListaSenhaAdmin);
            cckSenha.Enabled = false;
            foreach (string item in loginSelecao)
            {
                cbxLogin.Items.Add(item);
            }
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            btnLogin.Enabled = false;
        }

        private void CbxLogin_SelectedIndexChanged(object sender, EventArgs e)
        {    
            if (cbxLogin.Text != null)
            {
                txtLogin.Enabled = true;
                txtSenha.Enabled = true;
                btnLogin.Enabled = true;
            }
            if (cbxLogin.Text == "[Selecione]")
            {
                cckSenha.Enabled = false;
            }
            else
            {
                cckSenha.Enabled = true;
            }
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            if (cbxLogin.Text == "Admin")
            {            
                string login = txtLogin.Text;
                string senha = txtSenha.Text;
                if (BancoAcademia.Autenticação(ListaIdAdmin, login))
                {
                    if (BancoAcademia.Autenticação(ListaSenhaAdmin, senha))
                    {
                        MessageBox.Show("Login realizado com sucesso, seja bem-vindo.", "Bem-vindo", MessageBoxButtons.OK);
                        formTurmas turmas = new formTurmas();
                        turmas.Show();
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta para este ID, verifique sua senha e tente novamente.", "Erro de senha", MessageBoxButtons.OK);
                        txtSenha.Clear();
                        txtSenha.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("ID não registrado, verifique se seu ID foi escrito corretamente.", "Erro de ID", MessageBoxButtons.OK);
                    txtLogin.Focus();
                }
            }
            else if (cbxLogin.Text == "Professor")
            {
                BancoAcademia.LerArquivoProf(ListaCpfProf, ListaNomeProf, ListaSobrenomeProf, ListaSenhaProf, ListaTelefoneProf, ListaRgProf, ListaGeneroProf, ListaNascimentoProf, ListaCodigoTurmaProf);
                string loginProf = txtLogin.Text;
                string senhaProf = txtSenha.Text;
                if (BancoAcademia.Autenticação(ListaCpfProf, loginProf))
                {
                    if (BancoAcademia.Autenticação(ListaSenhaProf, senhaProf))
                    {
                        MessageBox.Show("Login realizado com sucesso, seja bem-vindo.", "Bem-vindo", MessageBoxButtons.OK);
                        formTurmas turmas = new formTurmas();
                        turmas.Show();
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta para este ID, verifique sua senha e tente novamente.", "Erro de senha", MessageBoxButtons.OK);
                        txtSenha.Clear();
                        txtSenha.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("ID não registrado, verifique se seu ID foi escrito corretamente.", "Erro de ID", MessageBoxButtons.OK);
                    txtLogin.Focus();
                }
            }
        }

        private void cckSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cckSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }
    }
}
