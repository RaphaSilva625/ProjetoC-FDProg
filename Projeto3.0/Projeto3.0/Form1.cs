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

namespace Projeto3._0
{
    public partial class formLogin : Form
    {
        string[,] MatrizCategoria = new string[1, 4];
        public int nLinhas = 0;
        public string[] dadosColetados;
        public void AttLista()
        {

            StreamReader sw = new StreamReader(@"D:\bdProjeto\bdTurmas.txt", true);
            string linha;
            while (true)
            {
                if (((linha = sw.ReadLine()) != null))
                {
                    dadosColetados = linha.Split(';');
                    for (int lin = 0; lin < nLinhas; lin++)
                    {
                        for (int col = 0; col < 4; col++)
                        {
                            MatrizCategoria[lin, col] = dadosColetados[col];
                        }

                    }
                }
                else
                    break;

            }
            sw.Close();
        }
        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        public formLogin()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnListarTurmas_Click(object sender, EventArgs e)
        {
            string[] vet1 = new string[4];
            for (int i = 0; i < 4; i++)
            {
                vet1[i] = MatrizCategoria[0, i];
            }
            dataGridView1.DataSource = vet1[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
