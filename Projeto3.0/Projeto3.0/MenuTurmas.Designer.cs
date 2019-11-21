namespace Projeto3._0
{
    partial class formTurmas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTurmas));
            this.btnEditarTurmas = new System.Windows.Forms.Button();
            this.btnListarTurmas = new System.Windows.Forms.Button();
            this.btnDeletarTurmas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarTurmas = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novosCadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtIdEdit = new System.Windows.Forms.TextBox();
            this.txtTipoEdit = new System.Windows.Forms.TextBox();
            this.txtHorarioEdit = new System.Windows.Forms.TextBox();
            this.lblIdEdit = new System.Windows.Forms.Label();
            this.lblTipoEdit = new System.Windows.Forms.Label();
            this.lblHorarioEdit = new System.Windows.Forms.Label();
            this.lblDiaEdit = new System.Windows.Forms.Label();
            this.btnSalvarEdit = new System.Windows.Forms.Button();
            this.lblProfEdit = new System.Windows.Forms.Label();
            this.cbxDiaEdit = new System.Windows.Forms.ComboBox();
            this.cbxProfTurma = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEditarTurmas
            // 
            this.btnEditarTurmas.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditarTurmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarTurmas.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarTurmas.Image")));
            this.btnEditarTurmas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarTurmas.Location = new System.Drawing.Point(312, 95);
            this.btnEditarTurmas.Name = "btnEditarTurmas";
            this.btnEditarTurmas.Size = new System.Drawing.Size(119, 92);
            this.btnEditarTurmas.TabIndex = 20;
            this.btnEditarTurmas.TabStop = false;
            this.btnEditarTurmas.Text = "Editar";
            this.btnEditarTurmas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarTurmas.UseVisualStyleBackColor = false;
            this.btnEditarTurmas.Click += new System.EventHandler(this.BtnEditarTurmas_Click);
            // 
            // btnListarTurmas
            // 
            this.btnListarTurmas.BackColor = System.Drawing.SystemColors.Control;
            this.btnListarTurmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarTurmas.Image = ((System.Drawing.Image)(resources.GetObject("btnListarTurmas.Image")));
            this.btnListarTurmas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnListarTurmas.Location = new System.Drawing.Point(437, 95);
            this.btnListarTurmas.Name = "btnListarTurmas";
            this.btnListarTurmas.Size = new System.Drawing.Size(119, 92);
            this.btnListarTurmas.TabIndex = 19;
            this.btnListarTurmas.Text = "Listar";
            this.btnListarTurmas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnListarTurmas.UseVisualStyleBackColor = false;
            this.btnListarTurmas.Click += new System.EventHandler(this.btnListarTurmas_Click);
            // 
            // btnDeletarTurmas
            // 
            this.btnDeletarTurmas.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeletarTurmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarTurmas.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletarTurmas.Image")));
            this.btnDeletarTurmas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeletarTurmas.Location = new System.Drawing.Point(187, 95);
            this.btnDeletarTurmas.Name = "btnDeletarTurmas";
            this.btnDeletarTurmas.Size = new System.Drawing.Size(119, 92);
            this.btnDeletarTurmas.TabIndex = 18;
            this.btnDeletarTurmas.Text = "Deletar";
            this.btnDeletarTurmas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeletarTurmas.UseVisualStyleBackColor = false;
            this.btnDeletarTurmas.Click += new System.EventHandler(this.BtnDeletarTurmas_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Escolha a opção desejada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Olá, Bem vindo ao menu de turmas!";
            // 
            // btnCadastrarTurmas
            // 
            this.btnCadastrarTurmas.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarTurmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarTurmas.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarTurmas.Image")));
            this.btnCadastrarTurmas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarTurmas.Location = new System.Drawing.Point(62, 95);
            this.btnCadastrarTurmas.Name = "btnCadastrarTurmas";
            this.btnCadastrarTurmas.Size = new System.Drawing.Size(119, 92);
            this.btnCadastrarTurmas.TabIndex = 12;
            this.btnCadastrarTurmas.Text = "Cadastrar";
            this.btnCadastrarTurmas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarTurmas.UseVisualStyleBackColor = false;
            this.btnCadastrarTurmas.Click += new System.EventHandler(this.BtnCadastrarTurmas_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(62, 202);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(494, 111);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novosCadastrosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novosCadastrosToolStripMenuItem
            // 
            this.novosCadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.professorToolStripMenuItem});
            this.novosCadastrosToolStripMenuItem.Name = "novosCadastrosToolStripMenuItem";
            this.novosCadastrosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.novosCadastrosToolStripMenuItem.Text = "Usuários";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // professorToolStripMenuItem
            // 
            this.professorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.pesquisarToolStripMenuItem});
            this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            this.professorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.professorToolStripMenuItem.Text = "Professor";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroToolStripMenuItem.Image")));
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.CadastroToolStripMenuItem_Click);
            // 
            // pesquisarToolStripMenuItem
            // 
            this.pesquisarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pesquisarToolStripMenuItem.Image")));
            this.pesquisarToolStripMenuItem.Name = "pesquisarToolStripMenuItem";
            this.pesquisarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.pesquisarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pesquisarToolStripMenuItem.Text = "Pesquisar";
            this.pesquisarToolStripMenuItem.Click += new System.EventHandler(this.PesquisarToolStripMenuItem_Click);
            // 
            // txtIdEdit
            // 
            this.txtIdEdit.Location = new System.Drawing.Point(62, 351);
            this.txtIdEdit.Name = "txtIdEdit";
            this.txtIdEdit.Size = new System.Drawing.Size(42, 20);
            this.txtIdEdit.TabIndex = 25;
            // 
            // txtTipoEdit
            // 
            this.txtTipoEdit.Location = new System.Drawing.Point(127, 351);
            this.txtTipoEdit.Name = "txtTipoEdit";
            this.txtTipoEdit.Size = new System.Drawing.Size(100, 20);
            this.txtTipoEdit.TabIndex = 26;
            this.txtTipoEdit.Visible = false;
            this.txtTipoEdit.TextChanged += new System.EventHandler(this.TxtTipoEdit_TextChanged);
            // 
            // txtHorarioEdit
            // 
            this.txtHorarioEdit.Location = new System.Drawing.Point(253, 351);
            this.txtHorarioEdit.Name = "txtHorarioEdit";
            this.txtHorarioEdit.Size = new System.Drawing.Size(53, 20);
            this.txtHorarioEdit.TabIndex = 27;
            this.txtHorarioEdit.Visible = false;
            // 
            // lblIdEdit
            // 
            this.lblIdEdit.AutoSize = true;
            this.lblIdEdit.Location = new System.Drawing.Point(62, 332);
            this.lblIdEdit.Name = "lblIdEdit";
            this.lblIdEdit.Size = new System.Drawing.Size(18, 13);
            this.lblIdEdit.TabIndex = 29;
            this.lblIdEdit.Text = "ID";
            // 
            // lblTipoEdit
            // 
            this.lblTipoEdit.AutoSize = true;
            this.lblTipoEdit.Location = new System.Drawing.Point(124, 335);
            this.lblTipoEdit.Name = "lblTipoEdit";
            this.lblTipoEdit.Size = new System.Drawing.Size(28, 13);
            this.lblTipoEdit.TabIndex = 30;
            this.lblTipoEdit.Text = "Tipo";
            // 
            // lblHorarioEdit
            // 
            this.lblHorarioEdit.AutoSize = true;
            this.lblHorarioEdit.Location = new System.Drawing.Point(250, 335);
            this.lblHorarioEdit.Name = "lblHorarioEdit";
            this.lblHorarioEdit.Size = new System.Drawing.Size(41, 13);
            this.lblHorarioEdit.TabIndex = 31;
            this.lblHorarioEdit.Text = "Horario";
            // 
            // lblDiaEdit
            // 
            this.lblDiaEdit.AutoSize = true;
            this.lblDiaEdit.Location = new System.Drawing.Point(328, 335);
            this.lblDiaEdit.Name = "lblDiaEdit";
            this.lblDiaEdit.Size = new System.Drawing.Size(28, 13);
            this.lblDiaEdit.TabIndex = 32;
            this.lblDiaEdit.Text = "Dias";
            // 
            // btnSalvarEdit
            // 
            this.btnSalvarEdit.Location = new System.Drawing.Point(62, 381);
            this.btnSalvarEdit.Name = "btnSalvarEdit";
            this.btnSalvarEdit.Size = new System.Drawing.Size(494, 23);
            this.btnSalvarEdit.TabIndex = 33;
            this.btnSalvarEdit.Text = "Salvar alterações";
            this.btnSalvarEdit.UseVisualStyleBackColor = true;
            this.btnSalvarEdit.TextChanged += new System.EventHandler(this.TxtTipoEdit_TextChanged);
            this.btnSalvarEdit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblProfEdit
            // 
            this.lblProfEdit.AutoSize = true;
            this.lblProfEdit.Enabled = false;
            this.lblProfEdit.Location = new System.Drawing.Point(451, 334);
            this.lblProfEdit.Name = "lblProfEdit";
            this.lblProfEdit.Size = new System.Drawing.Size(62, 13);
            this.lblProfEdit.TabIndex = 35;
            this.lblProfEdit.Text = "Professores";
            this.lblProfEdit.Visible = false;
            // 
            // cbxDiaEdit
            // 
            this.cbxDiaEdit.FormattingEnabled = true;
            this.cbxDiaEdit.Location = new System.Drawing.Point(331, 351);
            this.cbxDiaEdit.Name = "cbxDiaEdit";
            this.cbxDiaEdit.Size = new System.Drawing.Size(100, 21);
            this.cbxDiaEdit.TabIndex = 36;
            // 
            // cbxProfTurma
            // 
            this.cbxProfTurma.FormattingEnabled = true;
            this.cbxProfTurma.Location = new System.Drawing.Point(454, 351);
            this.cbxProfTurma.Name = "cbxProfTurma";
            this.cbxProfTurma.Size = new System.Drawing.Size(102, 21);
            this.cbxProfTurma.TabIndex = 37;
            // 
            // formTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(614, 418);
            this.Controls.Add(this.cbxProfTurma);
            this.Controls.Add(this.cbxDiaEdit);
            this.Controls.Add(this.lblProfEdit);
            this.Controls.Add(this.btnSalvarEdit);
            this.Controls.Add(this.lblDiaEdit);
            this.Controls.Add(this.lblHorarioEdit);
            this.Controls.Add(this.lblTipoEdit);
            this.Controls.Add(this.lblIdEdit);
            this.Controls.Add(this.txtHorarioEdit);
            this.Controls.Add(this.txtTipoEdit);
            this.Controls.Add(this.txtIdEdit);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnEditarTurmas);
            this.Controls.Add(this.btnListarTurmas);
            this.Controls.Add(this.btnDeletarTurmas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrarTurmas);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "formTurmas";
            this.Text = "Gym Manager";
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditarTurmas;
        private System.Windows.Forms.Button btnListarTurmas;
        private System.Windows.Forms.Button btnDeletarTurmas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarTurmas;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem novosCadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtIdEdit;
        private System.Windows.Forms.TextBox txtTipoEdit;
        private System.Windows.Forms.TextBox txtHorarioEdit;
        private System.Windows.Forms.Label lblIdEdit;
        private System.Windows.Forms.Label lblTipoEdit;
        private System.Windows.Forms.Label lblHorarioEdit;
        private System.Windows.Forms.Label lblDiaEdit;
        private System.Windows.Forms.Button btnSalvarEdit;
        private System.Windows.Forms.Label lblProfEdit;
        private System.Windows.Forms.ComboBox cbxDiaEdit;
        private System.Windows.Forms.ComboBox cbxProfTurma;
    }
}

