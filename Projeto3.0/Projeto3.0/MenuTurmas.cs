using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace Projeto3._0
{
    
    public partial class formTurmas : Form
    {
        public static ArrayList ListaCodigoTurma = new ArrayList();
        public static ArrayList ListaTipoTurma = new ArrayList();
        public static ArrayList ListaHorarioTurma = new ArrayList();
        public static ArrayList ListaDiasTurma = new ArrayList();
        public static ArrayList ListaProfTurma = new ArrayList();

        public static ArrayList ListaNomeProf = new ArrayList();
        public static ArrayList ListaSobrenomeProf = new ArrayList();
        public static ArrayList ListaSenhaProf = new ArrayList();
        public static ArrayList ListaTelefoneProf = new ArrayList();
        public static ArrayList ListaCpfProf = new ArrayList();
        public static ArrayList ListaRgProf = new ArrayList();
        public static ArrayList ListaGeneroProf = new ArrayList();
        public static ArrayList ListaDataProf = new ArrayList();
        public static ArrayList ListaCodigoTurmaProf = new ArrayList();

        string[] diasDeAula = {
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sextaa",
            "Sabado",
            "Domingo" };

        private void formLogin_Load(object sender, EventArgs e)
        {

            txtIdEdit.Enabled = false;
            txtIdEdit.Visible = false;
            txtTipoEdit.Enabled = false;
            txtHorarioEdit.Enabled = false;
            cbxDiaEdit.Enabled = false;
            cbxDiaEdit.Visible = false;
            lblIdEdit.Visible = false;
            lblTipoEdit.Visible = false;
            lblHorarioEdit.Visible = false;
            lblDiaEdit.Visible = false;
            btnSalvarEdit.Enabled = false;
            btnSalvarEdit.Visible = false;
            cbxProfTurma.Visible = false;
        }

        public formTurmas()
        {
            InitializeComponent();         
            listView1.Columns.Add("Codigo", 40);
            listView1.Columns.Add("Tipo", 125);
            listView1.Columns.Add("Horario", 50);
            listView1.Columns.Add("Dias", 125);
            listView1.Columns.Add("Professor", 125);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListarTurmas_Click(object sender, EventArgs e)
        {
            BancoAcademia.LerArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma, ListaProfTurma);
            BancoAcademia.LerArquivoProf(ListaCpfProf, ListaNomeProf, ListaSobrenomeProf, ListaSenhaProf, ListaTelefoneProf, ListaRgProf, ListaGeneroProf, ListaDataProf, ListaCodigoTurmaProf);

            foreach (var professor in ListaNomeProf)
            {
                cbxProfTurma.Items.Add(professor);
            }

            if (ListaCodigoTurma.Count == 0)
            {
                DialogResult resposta;
                resposta = MessageBox.Show("Não há turmas cadastradas, deseja criar uma turma nova?", "Erro", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    new CadastroTurmas().Show();
                }
            }
            listView1.Items.Clear();
            string[] vetorDeTeste = new string[5];
            ListViewItem itm;
            for (int i = 0; i < ListaCodigoTurma.Count; i++)
            {
                vetorDeTeste[0] = ListaCodigoTurma[i].ToString();
                vetorDeTeste[1] = ListaTipoTurma[i].ToString();
                vetorDeTeste[2] = ListaHorarioTurma[i].ToString();
                vetorDeTeste[3] = ListaDiasTurma[i].ToString();
                vetorDeTeste[4] = ListaProfTurma[i].ToString();

                itm = new ListViewItem(vetorDeTeste);
                listView1.Items.Add(itm);
            }
        }

        private void BtnCadastrarTurmas_Click(object sender, EventArgs e)
        {
            CadastroTurmas cadastroTurmas = new CadastroTurmas();
            cadastroTurmas.Show();
        }

        private void CadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new CadastroProfessores().Show();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIdEdit.Visible = true;
            txtTipoEdit.Visible = true;           
            cbxDiaEdit.Visible = true;        
            txtHorarioEdit.Visible = true;
            cbxProfTurma.Visible = true;

            for (int i = 0; i < ListaCodigoTurma.Count; i++)
            {
                if (listView1.FocusedItem.Text == ListaCodigoTurma[i].ToString())
                {
                    txtIdEdit.Text = ListaCodigoTurma[i].ToString();
                    txtTipoEdit.Text = ListaTipoTurma[i].ToString();
                    txtHorarioEdit.Text = ListaHorarioTurma[i].ToString();
                    cbxDiaEdit.Text = ListaDiasTurma[i].ToString();
                    cbxProfTurma.Text = ListaProfTurma[i].ToString();
                }
            }
        }

        private void BtnEditarTurmas_Click(object sender, EventArgs e)
        {
            txtTipoEdit.Enabled = true;
            cbxDiaEdit.Enabled = true;
            txtHorarioEdit.Enabled = true;
            btnSalvarEdit.Visible = true;
            btnSalvarEdit.Enabled = true;

            
        }

        private void Button1_Click(object sender, EventArgs e)
        {      
            for (int i = 0; i < ListaCodigoTurma.Count; i++)
            {
                if (txtIdEdit.Text == ListaCodigoTurma[i].ToString())
                {
                    ListaTipoTurma[i] = txtTipoEdit.Text;
                    ListaHorarioTurma[i] = txtHorarioEdit.Text;
                    ListaDiasTurma[i] = cbxDiaEdit.Text;
                    ListaProfTurma[i] = cbxProfTurma.Text;
                }
            }
            BancoAcademia.GravarArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma, ListaProfTurma);
            MessageBox.Show("Informações atualizadas com sucesso, clique listar para detalhes.", "Dados atualizados", MessageBoxButtons.OK);
        }

        private void TxtTipoEdit_TextChanged(object sender, EventArgs e)
        {
        }


        private void BtnDeletarTurmas_Click_1(object sender, EventArgs e)
        {
            DialogResult resposta;
            resposta = MessageBox.Show("Você deseja excluir a turma selecionada?", "Atenção", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                for (int i = 0; i < ListaCodigoTurma.Count; i++)
                {
                    if (txtIdEdit.Text == ListaCodigoTurma[i].ToString())
                    {
                        ListaCodigoTurma.Remove(ListaCodigoTurma[i]);
                        ListaTipoTurma.Remove(ListaTipoTurma[i]);
                        ListaHorarioTurma.Remove(ListaHorarioTurma[i]);
                        ListaDiasTurma.Remove(ListaDiasTurma[i]);
                        ListaProfTurma.Remove(ListaProfTurma[i]);
                        break;
                    }
                }
            }
            MessageBox.Show("Turma excluida com sucesso!!", "Atenção", MessageBoxButtons.OK);
            BancoAcademia.GravarArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma, ListaProfTurma);
        }

        private void PesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuProfessores professores = new MenuProfessores();
            professores.Show();
        }
    }
}
