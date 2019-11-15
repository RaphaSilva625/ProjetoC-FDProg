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
    public partial class TelaLogin : Form
    {
        //Lista de dados do professor
        #region 
        public static ArrayList ListaNomeProf = new ArrayList();
        public static ArrayList ListaSobrenomeProf = new ArrayList();
        public static ArrayList ListaTelefoneProf = new ArrayList();
        public static ArrayList ListaNascimentoProf = new ArrayList();
        public static ArrayList ListaRgProf = new ArrayList();
        public static ArrayList ListaCpfProf = new ArrayList();
        public static ArrayList ListaGeneroProf = new ArrayList();
        #endregion
        //Lista de dados do Admin
        #region
        public static ArrayList ListaIdAdmin = new ArrayList();
        public static ArrayList ListaSenhaAdmin = new ArrayList();
        #endregion

        string[] loginSelecao = { "Admin", "Professor", "Aluno" };

        public TelaLogin()
        {
            InitializeComponent();         
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            BancoAcademia.LerArquivoAdmin(ListaIdAdmin, ListaSenhaAdmin);
            BancoAcademia.LerArquivoProf(ListaNomeProf, ListaSobrenomeProf, ListaTelefoneProf, ListaNascimentoProf, ListaRgProf, ListaCpfProf, ListaGeneroProf);
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
            
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {            
            BancoAcademia.LerArquivoProf(ListaNomeProf, ListaSobrenomeProf, ListaTelefoneProf, ListaNascimentoProf, ListaRgProf, ListaCpfProf, ListaGeneroProf);
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
            if (BancoAcademia.Autenticação(ListaIdAdmin, login))
            {
                if (BancoAcademia.Autenticação(ListaSenhaAdmin, senha))
                {
                    MessageBox.Show("Login realizado com sucesso, seja bem-vindo.", "Bem-vindo", MessageBoxButtons.OK);
                    this.Close();
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
            //if (cbxLogin.Text == "Admin")
            //{
            //    for (int i = 0; i < ListaIdAdmin.Count; i++)
            //    {
            //        if (txtLogin.Text == Convert.ToString(ListaIdAdmin[i]) && txtSenha.Text == Convert.ToString(ListaSenhaAdmin[i]))
            //        {
            //            MessageBox.Show("Login realizado com sucesso!!", "Login", MessageBoxButtons.OK);                                           
            //        }
            //    }
            //    formTurmas telaTurmas = new formTurmas();
            //    telaTurmas.Show();                
            //}
        }
    }
}
