using Projeto.Cadastros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto;
using System.IO;

namespace Projeto
{
    public partial class Menu : Form
    {

        //  Declara as Variaveis globais (matriz)
        //  Carregar a matriz com os dados do arquivo
        
        public Menu()
        {
            InitializeComponent();
        }


        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroAlunos cadastroAluno = new CadastroAlunos();
            cadastroAluno.Show();
        }

        private void BtnCadastrarTurmas_Click(object sender, EventArgs e)
        {
            CadastroTurmas cadastroTurmas = new CadastroTurmas();
            cadastroTurmas.Show();
            
        }

        private void BtnListarTurmas_Click(object sender, EventArgs e)
        {
            TurmasDados.LerBdTurma(nomeCategoria);
        }

        public void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
