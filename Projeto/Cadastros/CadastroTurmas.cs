using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.Cadastros
{
    public partial class CadastroTurmas : Form
    {
        public CadastroTurmas()
        {
            InitializeComponent();
        }


        private void CadastroTurmas_Load(object sender, EventArgs e)
        {
            List<string> codTurmas = new List<string>();
            codTurmas.Add();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
