namespace Projeto
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnCadastrarTurmas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDeletarTurmas = new System.Windows.Forms.Button();
            this.btnListarTurmas = new System.Windows.Forms.Button();
            this.btnEditarTurmas = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichaDeExercícioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.criarNovaFichaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrarTurmas
            // 
            this.btnCadastrarTurmas.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarTurmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarTurmas.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarTurmas.Image")));
            this.btnCadastrarTurmas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarTurmas.Location = new System.Drawing.Point(96, 160);
            this.btnCadastrarTurmas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCadastrarTurmas.Name = "btnCadastrarTurmas";
            this.btnCadastrarTurmas.Size = new System.Drawing.Size(178, 142);
            this.btnCadastrarTurmas.TabIndex = 2;
            this.btnCadastrarTurmas.Text = "Cadastrar";
            this.btnCadastrarTurmas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarTurmas.UseVisualStyleBackColor = false;
            this.btnCadastrarTurmas.Click += new System.EventHandler(this.BtnCadastrarTurmas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Olá, Bem vindo ao menu de turmas!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Escolha a opção desejada:";
            // 
            // btnDeletarTurmas
            // 
            this.btnDeletarTurmas.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeletarTurmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarTurmas.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletarTurmas.Image")));
            this.btnDeletarTurmas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeletarTurmas.Location = new System.Drawing.Point(284, 160);
            this.btnDeletarTurmas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeletarTurmas.Name = "btnDeletarTurmas";
            this.btnDeletarTurmas.Size = new System.Drawing.Size(178, 142);
            this.btnDeletarTurmas.TabIndex = 9;
            this.btnDeletarTurmas.Text = "Deletar";
            this.btnDeletarTurmas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeletarTurmas.UseVisualStyleBackColor = false;
            // 
            // btnListarTurmas
            // 
            this.btnListarTurmas.BackColor = System.Drawing.SystemColors.Control;
            this.btnListarTurmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTurmas.Image = ((System.Drawing.Image)(resources.GetObject("btnListarTurmas.Image")));
            this.btnListarTurmas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListarTurmas.Location = new System.Drawing.Point(658, 160);
            this.btnListarTurmas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListarTurmas.Name = "btnListarTurmas";
            this.btnListarTurmas.Size = new System.Drawing.Size(178, 142);
            this.btnListarTurmas.TabIndex = 10;
            this.btnListarTurmas.Text = "Listar";
            this.btnListarTurmas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListarTurmas.UseVisualStyleBackColor = false;
            this.btnListarTurmas.Click += new System.EventHandler(this.BtnListarTurmas_Click);
            // 
            // btnEditarTurmas
            // 
            this.btnEditarTurmas.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditarTurmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTurmas.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarTurmas.Image")));
            this.btnEditarTurmas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarTurmas.Location = new System.Drawing.Point(471, 160);
            this.btnEditarTurmas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditarTurmas.Name = "btnEditarTurmas";
            this.btnEditarTurmas.Size = new System.Drawing.Size(178, 142);
            this.btnEditarTurmas.TabIndex = 11;
            this.btnEditarTurmas.TabStop = false;
            this.btnEditarTurmas.Text = "Editar";
            this.btnEditarTurmas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarTurmas.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.professoresToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(921, 36);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirToolStripMenuItem,
            this.fichaDeExercícioToolStripMenuItem});
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(83, 30);
            this.alunosToolStripMenuItem.Text = "Alunos";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.AlunosToolStripMenuItem_Click);
            // 
            // excluirToolStripMenuItem
            // 
            this.excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            this.excluirToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.excluirToolStripMenuItem.Text = "Pesquisar Turmas";
            // 
            // fichaDeExercícioToolStripMenuItem
            // 
            this.fichaDeExercícioToolStripMenuItem.Name = "fichaDeExercícioToolStripMenuItem";
            this.fichaDeExercícioToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.fichaDeExercícioToolStripMenuItem.Text = "Ficha de Exercício";
            // 
            // professoresToolStripMenuItem
            // 
            this.professoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem1,
            this.deletarToolStripMenuItem,
            this.editarToolStripMenuItem1,
            this.pesquisarToolStripMenuItem1,
            this.criarNovaFichaToolStripMenuItem});
            this.professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            this.professoresToolStripMenuItem.Size = new System.Drawing.Size(120, 30);
            this.professoresToolStripMenuItem.Text = "Professores";
            // 
            // cadastrarToolStripMenuItem1
            // 
            this.cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            this.cadastrarToolStripMenuItem1.Size = new System.Drawing.Size(240, 34);
            this.cadastrarToolStripMenuItem1.Text = "Novo Aluno";
            this.cadastrarToolStripMenuItem1.Click += new System.EventHandler(this.CadastrarToolStripMenuItem1_Click);
            // 
            // deletarToolStripMenuItem
            // 
            this.deletarToolStripMenuItem.Name = "deletarToolStripMenuItem";
            this.deletarToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.deletarToolStripMenuItem.Text = "Excluir Aluno";
            // 
            // editarToolStripMenuItem1
            // 
            this.editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            this.editarToolStripMenuItem1.Size = new System.Drawing.Size(240, 34);
            this.editarToolStripMenuItem1.Text = "Editar Aluno";
            // 
            // pesquisarToolStripMenuItem1
            // 
            this.pesquisarToolStripMenuItem1.Name = "pesquisarToolStripMenuItem1";
            this.pesquisarToolStripMenuItem1.Size = new System.Drawing.Size(240, 34);
            this.pesquisarToolStripMenuItem1.Text = "Pesquisar Aluno";
            // 
            // criarNovaFichaToolStripMenuItem
            // 
            this.criarNovaFichaToolStripMenuItem.Name = "criarNovaFichaToolStripMenuItem";
            this.criarNovaFichaToolStripMenuItem.Size = new System.Drawing.Size(240, 34);
            this.criarNovaFichaToolStripMenuItem.Text = "Criar nova ficha";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(81, 30);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(96, 358);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(739, 244);
            this.listBox1.TabIndex = 13;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 643);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnEditarTurmas);
            this.Controls.Add(this.btnListarTurmas);
            this.Controls.Add(this.btnDeletarTurmas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarTurmas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Menu";
            this.Text = "Gym Manager";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarTurmas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeletarTurmas;
        private System.Windows.Forms.Button btnListarTurmas;
        private System.Windows.Forms.Button btnEditarTurmas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichaDeExercícioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deletarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem criarNovaFichaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
    }
}

