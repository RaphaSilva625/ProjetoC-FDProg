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
            "Segundas",
            "Terças",
            "Quartas",
            "Quintas",
            "Sextas",
            "Sábados",
            "Domingos" };

        public static ArrayList ListaCodigoTurma = new ArrayList();
        public static ArrayList ListaTipoTurma = new ArrayList();
        public static ArrayList ListaHorarioTurma = new ArrayList();
        public static ArrayList ListaDiasTurma = new ArrayList();

        public static ArrayList ListaCpfProf = new ArrayList();
        public static ArrayList ListaNomeProf = new ArrayList();
        public static ArrayList ListaSobrenomeProf = new ArrayList();
        public static ArrayList ListaSenhaProf = new ArrayList();
        public static ArrayList ListaTelefoneProf = new ArrayList();
        public static ArrayList ListaRgProf = new ArrayList();
        public static ArrayList ListaGeneroProf = new ArrayList();
        public static ArrayList ListaNascimentoProf = new ArrayList();
        public static ArrayList ListaCodigoTurmaProf = new ArrayList();

        private static string[] professoresCpf;
        private static string[] professoresDisponiveis; 
        
        public CadastroTurmas()
        {
            InitializeComponent();
        }

        private void CadastroTurmas_Load(object sender, EventArgs e)
        {
            
            BancoAcademia.LerArquivoProf(ListaCpfProf, ListaNomeProf, ListaSobrenomeProf, ListaSenhaProf, ListaTelefoneProf, ListaRgProf, ListaGeneroProf, ListaNascimentoProf, ListaCodigoTurmaProf);
            int quantidadeDeProfessores = ListaCodigoTurmaProf.Count;
            professoresDisponiveis = new string[quantidadeDeProfessores];
            professoresCpf = new string[quantidadeDeProfessores];
            int contador = 0;
            foreach (string dias in diasDeAula)
            {
                cckListDias.Items.Add(dias);
            }
            
            for (int i = 0; i < ListaCpfProf.Count; i++)
            {
                if (ListaCodigoTurmaProf[i].ToString() == "Disponível" )
                {
                    professoresCpf[contador] = ListaCpfProf[i].ToString();
                    professoresDisponiveis[contador] = ListaCodigoTurmaProf[i].ToString();
                    contador++;
                }
            }
        }

        private void BtbSaveTurma_Click(object sender, EventArgs e)
        {
            BancoAcademia.LerArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma);
            string novoCodigo = lblCodTurma.Text;
            string novoTipo = txtTipoTurma.Text;
            string novoHorario = mtxtHorarioTurma.Text;
            string novoDia = "";

            #region Tratamento do codigo da turma
            if (lblCodTurma.Text == "")
            {
                MessageBox.Show("O código da turma é gerado automaticamente, apertando no botão Gerar Código!", "Aviso", MessageBoxButtons.OK);
                btnCodTurma.Focus();
                return;
            }
            #endregion 
            #region Tratamento dos dias
            ArrayList diasMarcados = new ArrayList();
            if (cckListDias.CheckedIndices.Count == 0 && cckListDias.CheckedIndices.Count > 3)
            {
                MessageBox.Show("Quantidade de dias inválido, três número máximo de dias.", "Erro", MessageBoxButtons.OK);
                cckListDias.Focus();
                return;
            }
            else if (cckListDias.CheckedIndices.Count == 1)
            {
                novoDia = cckListDias.SelectedItem.ToString();
            }           
            else if (cckListDias.CheckedIndices.Count == 2)
            {
                foreach (string dia in cckListDias.CheckedItems)
                {
                    diasMarcados.Add(dia);
                }
                novoDia = diasMarcados[0] + " e " + diasMarcados[1];
            }
            else if (cckListDias.CheckedIndices.Count == 3)
            {
                foreach (string dia in cckListDias.CheckedItems)
                {
                    diasMarcados.Add(dia);
                }
                novoDia = diasMarcados[0] + ", " + diasMarcados[1] + " e " + diasMarcados[2];
            }
            #endregion
            #region Tratamento de horarios
            int horas = Convert.ToInt32(novoHorario.Substring(0, 2));
            int min = Convert.ToInt32(novoHorario.Substring(3, 2));
            int ultimosMin = Convert.ToInt32(novoHorario.Substring(4, 1));
            if (horas < 00 && horas > 24)
            {
                MessageBox.Show("Hora no formato errado, utilize o formato 24h no padrão HH:MM.", "Erro", MessageBoxButtons.OK);
                mtxtHorarioTurma.Focus();
                return;
            }
            else if (min < 00 && min > 59)
            {
                MessageBox.Show("Minutos fora do intervalo válido, utilize minutos entre 00 e 59.", "Erro", MessageBoxButtons.OK);
                mtxtHorarioTurma.Focus();
                return;
            }
            else if (ultimosMin != 5 && ultimosMin != 0)
            {
                MessageBox.Show("As aulas sempre serão iniciadas em hórarios válidos, terminados sempre em 0 e 5min.\nExemplo: 16:05 ou 16:20", "Erro", MessageBoxButtons.OK);
                mtxtHorarioTurma.Focus();
                return;
            }
            for (int i = 0; i < ListaCodigoTurma.Count; i++)
            {
                string compararHorarioBd = Convert.ToString(ListaHorarioTurma[i]).Substring(0, 2);
                string compararNovoHorario = Convert.ToString(novoHorario).Substring(0, 2);
                if (compararNovoHorario == compararHorarioBd)
                {
                    MessageBox.Show("Existe um choque de hórario, por favor, revise os dias e hórarios para cadastrar a nova turma.", "Erro", MessageBoxButtons.OK);
                    DialogResult resposta = MessageBox.Show("Deseja voltar ao menu, para checar as turmas existentes ?", "Atenção", MessageBoxButtons.YesNo);
                    if (resposta == DialogResult.Yes)
                    {
                        formTurmas menu = new formTurmas();
                        menu.Show();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            #endregion
            #region Tratamento do tipo da turma
            string novoTipoTeste = novoTipo.ToUpper();
            for (int i = 0; i < novoTipoTeste.Length; i++)
            {
                if (String.Compare(novoTipoTeste.Substring(i, 1), "A") < 0 || String.Compare(novoTipoTeste.Substring(i, 1), "Z") > 0)
                {
                    MessageBox.Show("Digite apenas letras!", "Erro", MessageBoxButtons.OK);
                    txtTipoTurma.Focus();
                    return;
                }
            }
            #endregion
            BancoAcademia.GravarArquivoProf(ListaCpfProf, ListaNomeProf, ListaSobrenomeProf, ListaSenhaProf, ListaTelefoneProf, ListaRgProf, ListaGeneroProf, ListaNascimentoProf, ListaCodigoTurmaProf);
            BancoAcademia.NovaTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma, novoCodigo, novoTipo, novoHorario, novoDia);      
        }

        private void BtnCodTurma_Click(object sender, EventArgs e)
        {
            BancoAcademia.LerArquivoTurma(ListaCodigoTurma, ListaTipoTurma, ListaHorarioTurma, ListaDiasTurma);
            lblCodTurma.Visible = true;
            int quantidadeDeCodigos = ListaCodigoTurma.Count;
            if (Convert.ToString(ListaCodigoTurma.Count) == "0")
            {
                lblCodTurma.Text = "001";
            }
            else if (ListaCodigoTurma.Count > 0 && ListaCodigoTurma.Count < 10)
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

        private void BtnCancelarTurma_Click(object sender, EventArgs e)
        {
            this.Close();
        }  
    }
}
