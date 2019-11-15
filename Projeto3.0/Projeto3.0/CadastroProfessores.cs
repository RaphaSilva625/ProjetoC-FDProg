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
        public static ArrayList ListaNomeProf = new ArrayList();
        public static ArrayList ListaSobrenomeProf = new ArrayList();
        public static ArrayList ListaTelefoneProf = new ArrayList();
        public static ArrayList ListaNascimentoProf = new ArrayList();
        public static ArrayList ListaRgProf = new ArrayList();
        public static ArrayList ListaCpfProf = new ArrayList();
        public static ArrayList ListaGeneroProf = new ArrayList();
        
        public CadastroProfessores()
        {
            InitializeComponent();
            BancoAcademia.LerArquivoProf(ListaNomeProf, ListaSobrenomeProf, ListaTelefoneProf, ListaNascimentoProf, ListaRgProf, ListaCpfProf, ListaGeneroProf);
        }

        private void CadastroProfessores_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancelarProf_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
