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
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta",
            "Sabado",
            "Domingo" };

        public static ArrayList ListaCodigoTurma = new ArrayList();
        public static ArrayList ListaTipoTurma = new ArrayList();
        public static ArrayList ListaHorarioTurma = new ArrayList();
        public static ArrayList ListaDiasTurma = new ArrayList();
        public static ArrayList ListaProfTurma = new ArrayList();

        public static ArrayList ListaCpfProf = new ArrayList();
        public static ArrayList ListaNomeProf = new ArrayList();
        public static ArrayList ListaSobrenomeProf = new ArrayList();
        public static ArrayList ListaSenhaProf = new ArrayList();
        public static ArrayList ListaTelefoneProf = new ArrayList();
        public static ArrayList ListaRgProf = new ArrayList();
        public static ArrayList ListaGeneroProf = new ArrayList();
        public static ArrayList ListaNascimentoProf = new ArrayList();
        public static ArrayList ListaCodigoTurmaProf = new ArrayList();

        public CadastroTurmas()
        {
            InitializeComponent();
        }

        private void CadastroTurmas_Load(object sender, EventArgs e)
        {
            BancoAcademia.LerArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma, ListaProfTurma);
            BancoAcademia.LerArquivoProf(ListaCpfProf, ListaNomeProf, ListaSobrenomeProf, ListaSenhaProf, ListaTelefoneProf, ListaRgProf, ListaGeneroProf, ListaNascimentoProf, ListaCodigoTurmaProf);
            foreach (string dias in diasDeAula)
            {
                cbxDiasAula.Items.Add(dias);
            }
            foreach (var professor in ListaNomeProf)
            {
                cbxProfTurma.Items.Add(professor);
            }
        }

        private void BtbSaveTurma_Click(object sender, EventArgs e)
        {
            BancoAcademia.LerArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma, ListaProfTurma);
            string novoCodigo = lblCodTurma.Text;
            string novoTipo = txtTipoTurma.Text;
            string novoHorario = txtHorarioTurma.Text;
            string novoDia = Convert.ToString(cbxDiasAula.SelectedItem);
            string novoProf = Convert.ToString(cbxProfTurma.SelectedItem);

            //BancoAcademia.LerArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma);
            BancoAcademia.NovaTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma, ListaProfTurma, novoCodigo, novoTipo, novoHorario, novoDia, novoProf);           
        }

        private void BtnCodTurma_Click(object sender, EventArgs e)
        {
            BancoAcademia.LerArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma, ListaProfTurma);
            lblCodTurma.Visible = true;
            int quantidadeDeCodigos = ListaCodigoTurma.Count;
            if (ListaCodigoTurma.Count < 10)
            {
                lblCodTurma.Text = "00" + Convert.ToString(Convert.ToInt32(ListaCodigoTurma[quantidadeDeCodigos - 1]) + 1);
            }
            else if (ListaCodigoTurma.Count >= 10)
            {
                lblCodTurma.Text = "0" + Convert.ToString(Convert.ToInt32(ListaCodigoTurma[quantidadeDeCodigos - 1]) + 1);
            }
            else
            {
                lblCodTurma.Text = Convert.ToString(Convert.ToInt32(ListaCodigoTurma[quantidadeDeCodigos - 1]) + 1);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
