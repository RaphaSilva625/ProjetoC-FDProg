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
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(62, 202);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(494, 111);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.novosCadastrosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.novosCadastrosToolStripMenuItem.Text = "Novos cadastros";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            // 
            // professorToolStripMenuItem
            // 
            this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            this.professorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.professorToolStripMenuItem.Text = "Professor";
            // 
            // formTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 418);
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
    }
}

