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
    public partial class CadastroTurmas : Form
    {
        string[] diasDeAula = {
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira",
            "Sabado",
            "Domingo" };

        string contCodTurma = "4";

        public static ArrayList ListaCodigoTurma = new ArrayList();
        public static ArrayList ListaTipoTurma = new ArrayList();
        public static ArrayList ListaHorarioTurma = new ArrayList();
        public static ArrayList ListaDiasTurma = new ArrayList();

        public CadastroTurmas()
        {
            InitializeComponent();
        }

        private void CadastroTurmas_Load(object sender, EventArgs e)
        {
            foreach (string dias in diasDeAula)
            {
                cbxDiasAula.Items.Add(dias);
            }
        }

        private void BtbSaveTurma_Click(object sender, EventArgs e)
        {
            BancoAcademia.LerArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma);
            string novoCodigo = lblCodTurma.Text;
            string novoTipo = txtTipoTurma.Text;
            string novoHorario = txtHorarioTurma.Text;
            string novoDia = Convert.ToString(cbxDiasAula.SelectedItem);

            //BancoAcademia.LerArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma);
            BancoAcademia.NovaTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma, novoCodigo, novoTipo, novoHorario, novoDia);           
        }

        private void BtnCodTurma_Click(object sender, EventArgs e)
        {
            lblCodTurma.Visible = true;
            lblCodTurma.Text = "00" + contCodTurma;
        }
    }
}
