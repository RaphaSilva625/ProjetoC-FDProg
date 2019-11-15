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
        public static ArrayList TipoTurma = new ArrayList();
        public static ArrayList HorarioTurma = new ArrayList();
        public static ArrayList DiasTurma = new ArrayList();

        private void formLogin_Load(object sender, EventArgs e)
        { 
        }

        public formTurmas()
        {
            InitializeComponent();         
            listView1.Columns.Add("Codigo", 50);
            listView1.Columns.Add("Turma", 125);
            listView1.Columns.Add("Horario", 100);
            listView1.Columns.Add("Dias", 125);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListarTurmas_Click(object sender, EventArgs e)
        {
            BancoAcademia.LerArquivoTurma(ListaCodigoTurma, TipoTurma, HorarioTurma, DiasTurma);
            listView1.Items.Clear();
            string[] vetorDeTeste = new string[4];
            ListViewItem itm;
            for (int i = 0; i < ListaCodigoTurma.Count; i++)
            {
                vetorDeTeste[0] = ListaCodigoTurma[i].ToString();
                vetorDeTeste[0 + 1] = TipoTurma[i].ToString();
                vetorDeTeste[0 + 2] = HorarioTurma[i].ToString();
                vetorDeTeste[0 + 3] = DiasTurma[i].ToString();
                itm = new ListViewItem(vetorDeTeste);
                listView1.Items.Add(itm);
            }
        }

        private void BtnCadastrarTurmas_Click(object sender, EventArgs e)
        {
            CadastroTurmas cadastroTurmas = new CadastroTurmas();
            cadastroTurmas.Show();
        }

    }
}
