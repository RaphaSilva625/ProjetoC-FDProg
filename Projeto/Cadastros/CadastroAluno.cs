using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Projeto
{
    public partial class CadastroAlunos : Form
    {
        public CadastroAlunos()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void BtnGerarNumeros_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            randNum.Next();
            listView1.Items.Add(Convert.ToString(randNum.Next(9000, 9999)));

            listView1.Show();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
