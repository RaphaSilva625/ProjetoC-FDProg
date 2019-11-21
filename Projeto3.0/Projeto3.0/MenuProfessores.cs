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
            txtTelefoneProf.Enabled = false;
            txtCpfProf.Enabled = false;
            txtRgProf.Enabled = false;
            txtGeneroProf.Enabled = false;
            txtDataProf.Enabled = false;
            cbxCodigoTurma.Enabled = false;
            btnSalvarEditProf.Enabled = false;
            btnSalvarEditProf.Visible = false;

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
                dadosProf[7] = ListaCodigoTurmaProf[i].ToString();
                prof = new ListViewItem(dadosProf);
                lvProf.Items.Add(prof);
            }
        }
    }
}
