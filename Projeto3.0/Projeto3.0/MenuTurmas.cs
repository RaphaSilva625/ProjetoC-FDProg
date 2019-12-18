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
            btnDeletarTurmas.Enabled = false;
            btnEditarTurmas.Enabled = false;
        }

        public formTurmas()
        {
            InitializeComponent();         
            listView1.Columns.Add("Codigo", 55);
            listView1.Columns.Add("Tipo", 135);
            listView1.Columns.Add("Horario", 65);
            listView1.Columns.Add("Dias", 135);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListarTurmas_Click(object sender, EventArgs e)
        {
            BancoAcademia.LerArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma);          
            BancoAcademia.LerArquivoProf(ListaCpfProf, ListaNomeProf, ListaSobrenomeProf, ListaSenhaProf, ListaTelefoneProf, ListaRgProf, ListaGeneroProf, ListaDataProf, ListaCodigoTurmaProf);
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
            btnDeletarTurmas.Enabled = true;
            btnEditarTurmas.Enabled = true;

            for (int i = 0; i < ListaCodigoTurma.Count; i++)
            {
                if (listView1.FocusedItem.Text == ListaCodigoTurma[i].ToString())
                {
                    txtIdEdit.Text = ListaCodigoTurma[i].ToString();
                    txtTipoEdit.Text = ListaTipoTurma[i].ToString();
                    txtHorarioEdit.Text = ListaHorarioTurma[i].ToString();
                    cbxDiaEdit.Text = ListaDiasTurma[i].ToString();
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
                }
            }
            BancoAcademia.GravarArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma);
            MessageBox.Show("Informações atualizadas com sucesso, clique listar para detalhes.", "Atenção", MessageBoxButtons.OK);
        }

        private void TxtTipoEdit_TextChanged(object sender, EventArgs e)
        {
        }


        private void BtnDeletarTurmas_Click_1(object sender, EventArgs e)
        {
            if (ListaCodigoTurmaProf.Contains(txtIdEdit.Text))
            {
                MessageBox.Show("A turma não pode ser deletada, favor desvincular o professor.", "Erro", MessageBoxButtons.OK);
                return;
            }
            else
            {
                DialogResult resposta;
                resposta = MessageBox.Show("Você deseja excluir a turma selecionada?", "Aviso", MessageBoxButtons.YesNo);
                if (resposta == DialogResult.Yes)
                {
                    for (int j = 0; j < ListaCodigoTurma.Count; j++)
                    {
                        if (txtIdEdit.Text.ToString() == ListaCodigoTurma[j].ToString())
                        {
                            ListaCodigoTurma.Remove(ListaCodigoTurma[j]);
                            ListaTipoTurma.Remove(ListaTipoTurma[j]);
                            ListaHorarioTurma.Remove(ListaHorarioTurma[j]);
                            ListaDiasTurma.Remove(ListaDiasTurma[j]);
                            MessageBox.Show("Turma excluida com sucesso!!", "Aviso", MessageBoxButtons.OK);
                            BancoAcademia.GravarArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma);
                            return;
                        }
                    }
                }
                else
                {
                    return;
                }
            }         
        }

        private void PesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuProfessores professores = new MenuProfessores();
            professores.Show();
        }

        private void AlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon... Don't be sad.", "Wait for it", MessageBoxButtons.OK);
        }
    }
}
