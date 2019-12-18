namespace Projeto3._0
{
    partial class MenuProfessores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvProf = new System.Windows.Forms.ListView();
            this.btnEditProf = new System.Windows.Forms.Button();
            this.btnDeleteProf = new System.Windows.Forms.Button();
            this.btnListarProf = new System.Windows.Forms.Button();
            this.txtNomeProf = new System.Windows.Forms.TextBox();
            this.txtSobrenomeProf = new System.Windows.Forms.TextBox();
            this.txtSenhaProf = new System.Windows.Forms.TextBox();
            this.txtCpfProf = new System.Windows.Forms.TextBox();
            this.txtRgProf = new System.Windows.Forms.TextBox();
            this.lblNomeProf = new System.Windows.Forms.Label();
            this.lblSobrenomeProf = new System.Windows.Forms.Label();
            this.lblSenhaProf = new System.Windows.Forms.Label();
            this.lblTelefoneProf = new System.Windows.Forms.Label();
            this.lblCpfProf = new System.Windows.Forms.Label();
            this.lblRgProf = new System.Windows.Forms.Label();
            this.lblGeneroProf = new System.Windows.Forms.Label();
            this.lblDataProf = new System.Windows.Forms.Label();
            this.btnSalvarEditProf = new System.Windows.Forms.Button();
            this.cbxCodigoTurma = new System.Windows.Forms.ComboBox();
            this.lblTurmaProf = new System.Windows.Forms.Label();
            this.cckSenhaProf = new System.Windows.Forms.CheckBox();
            this.cbxGeneroProf = new System.Windows.Forms.ComboBox();
            this.mtxtTelefoneProf = new System.Windows.Forms.MaskedTextBox();
            this.mtxtDataProf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lvProf
            // 
            this.lvProf.HideSelection = false;
            this.lvProf.Location = new System.Drawing.Point(47, 87);
            this.lvProf.Name = "lvProf";
            this.lvProf.Size = new System.Drawing.Size(570, 158);
            this.lvProf.TabIndex = 0;
            this.lvProf.UseCompatibleStateImageBehavior = false;
            this.lvProf.View = System.Windows.Forms.View.Details;
            this.lvProf.SelectedIndexChanged += new System.EventHandler(this.LvProf_SelectedIndexChanged);
            // 
            // btnEditProf
            // 
            this.btnEditProf.Location = new System.Drawing.Point(47, 58);
            this.btnEditProf.Name = "btnEditProf";
            this.btnEditProf.Size = new System.Drawing.Size(125, 23);
            this.btnEditProf.TabIndex = 1;
            this.btnEditProf.Text = "Editar";
            this.btnEditProf.UseVisualStyleBackColor = true;
            this.btnEditProf.Click += new System.EventHandler(this.BtnEditProf_Click);
            // 
            // btnDeleteProf
            // 
            this.btnDeleteProf.Location = new System.Drawing.Point(195, 58);
            this.btnDeleteProf.Name = "btnDeleteProf";
            this.btnDeleteProf.Size = new System.Drawing.Size(125, 23);
            this.btnDeleteProf.TabIndex = 2;
            this.btnDeleteProf.Text = "Deletar";
            this.btnDeleteProf.UseVisualStyleBackColor = true;
            this.btnDeleteProf.Click += new System.EventHandler(this.BtnDeleteProf_Click);
            // 
            // btnListarProf
            // 
            this.btnListarProf.Location = new System.Drawing.Point(342, 58);
            this.btnListarProf.Name = "btnListarProf";
            this.btnListarProf.Size = new System.Drawing.Size(275, 23);
            this.btnListarProf.TabIndex = 3;
            this.btnListarProf.Text = "Listar";
            this.btnListarProf.UseVisualStyleBackColor = true;
            this.btnListarProf.Click += new System.EventHandler(this.BtnListarProf_Click);
            // 
            // txtNomeProf
            // 
            this.txtNomeProf.Location = new System.Drawing.Point(47, 282);
            this.txtNomeProf.Name = "txtNomeProf";
            this.txtNomeProf.Size = new System.Drawing.Size(100, 20);
            this.txtNomeProf.TabIndex = 0;
            // 
            // txtSobrenomeProf
            // 
            this.txtSobrenomeProf.Location = new System.Drawing.Point(167, 282);
            this.txtSobrenomeProf.Name = "txtSobrenomeProf";
            this.txtSobrenomeProf.Size = new System.Drawing.Size(100, 20);
            this.txtSobrenomeProf.TabIndex = 1;
            // 
            // txtSenhaProf
            // 
            this.txtSenhaProf.Location = new System.Drawing.Point(287, 282);
            this.txtSenhaProf.Name = "txtSenhaProf";
            this.txtSenhaProf.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaProf.TabIndex = 2;
            this.txtSenhaProf.UseSystemPasswordChar = true;
            // 
            // txtCpfProf
            // 
            this.txtCpfProf.Location = new System.Drawing.Point(47, 327);
            this.txtCpfProf.Name = "txtCpfProf";
            this.txtCpfProf.Size = new System.Drawing.Size(142, 20);
            this.txtCpfProf.TabIndex = 8;
            // 
            // txtRgProf
            // 
            this.txtRgProf.Location = new System.Drawing.Point(217, 327);
            this.txtRgProf.Name = "txtRgProf";
            this.txtRgProf.Size = new System.Drawing.Size(142, 20);
            this.txtRgProf.TabIndex = 9;
            // 
            // lblNomeProf
            // 
            this.lblNomeProf.AutoSize = true;
            this.lblNomeProf.Location = new System.Drawing.Point(47, 263);
            this.lblNomeProf.Name = "lblNomeProf";
            this.lblNomeProf.Size = new System.Drawing.Size(35, 13);
            this.lblNomeProf.TabIndex = 12;
            this.lblNomeProf.Text = "Nome";
            // 
            // lblSobrenomeProf
            // 
            this.lblSobrenomeProf.AutoSize = true;
            this.lblSobrenomeProf.Location = new System.Drawing.Point(164, 266);
            this.lblSobrenomeProf.Name = "lblSobrenomeProf";
            this.lblSobrenomeProf.Size = new System.Drawing.Size(61, 13);
            this.lblSobrenomeProf.TabIndex = 13;
            this.lblSobrenomeProf.Text = "Sobrenome";
            // 
            // lblSenhaProf
            // 
            this.lblSenhaProf.AutoSize = true;
            this.lblSenhaProf.Location = new System.Drawing.Point(284, 266);
            this.lblSenhaProf.Name = "lblSenhaProf";
            this.lblSenhaProf.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaProf.TabIndex = 14;
            this.lblSenhaProf.Text = "Senha";
            // 
            // lblTelefoneProf
            // 
            this.lblTelefoneProf.AutoSize = true;
            this.lblTelefoneProf.Location = new System.Drawing.Point(403, 266);
            this.lblTelefoneProf.Name = "lblTelefoneProf";
            this.lblTelefoneProf.Size = new System.Drawing.Size(49, 13);
            this.lblTelefoneProf.TabIndex = 15;
            this.lblTelefoneProf.Text = "Telefone";
            // 
            // lblCpfProf
            // 
            this.lblCpfProf.AutoSize = true;
            this.lblCpfProf.Location = new System.Drawing.Point(47, 311);
            this.lblCpfProf.Name = "lblCpfProf";
            this.lblCpfProf.Size = new System.Drawing.Size(27, 13);
            this.lblCpfProf.TabIndex = 16;
            this.lblCpfProf.Text = "CPF";
            // 
            // lblRgProf
            // 
            this.lblRgProf.AutoSize = true;
            this.lblRgProf.Location = new System.Drawing.Point(214, 311);
            this.lblRgProf.Name = "lblRgProf";
            this.lblRgProf.Size = new System.Drawing.Size(23, 13);
            this.lblRgProf.TabIndex = 17;
            this.lblRgProf.Text = "RG";
            // 
            // lblGeneroProf
            // 
            this.lblGeneroProf.AutoSize = true;
            this.lblGeneroProf.Location = new System.Drawing.Point(385, 311);
            this.lblGeneroProf.Name = "lblGeneroProf";
            this.lblGeneroProf.Size = new System.Drawing.Size(42, 13);
            this.lblGeneroProf.TabIndex = 18;
            this.lblGeneroProf.Text = "Genero";
            // 
            // lblDataProf
            // 
            this.lblDataProf.AutoSize = true;
            this.lblDataProf.Location = new System.Drawing.Point(514, 311);
            this.lblDataProf.Name = "lblDataProf";
            this.lblDataProf.Size = new System.Drawing.Size(102, 13);
            this.lblDataProf.TabIndex = 19;
            this.lblDataProf.Text = "Data de nascimento";
            // 
            // btnSalvarEditProf
            // 
            this.btnSalvarEditProf.Location = new System.Drawing.Point(47, 354);
            this.btnSalvarEditProf.Name = "btnSalvarEditProf";
            this.btnSalvarEditProf.Size = new System.Drawing.Size(570, 23);
            this.btnSalvarEditProf.TabIndex = 7;
            this.btnSalvarEditProf.Text = "Salvar alterações";
            this.btnSalvarEditProf.UseVisualStyleBackColor = true;
            this.btnSalvarEditProf.Click += new System.EventHandler(this.BtnSalvarEditProf_Click);
            // 
            // cbxCodigoTurma
            // 
            this.cbxCodigoTurma.FormattingEnabled = true;
            this.cbxCodigoTurma.Location = new System.Drawing.Point(567, 282);
            this.cbxCodigoTurma.Name = "cbxCodigoTurma";
            this.cbxCodigoTurma.Size = new System.Drawing.Size(50, 21);
            this.cbxCodigoTurma.TabIndex = 4;
            // 
            // lblTurmaProf
            // 
            this.lblTurmaProf.AutoSize = true;
            this.lblTurmaProf.Location = new System.Drawing.Point(567, 266);
            this.lblTurmaProf.Name = "lblTurmaProf";
            this.lblTurmaProf.Size = new System.Drawing.Size(37, 13);
            this.lblTurmaProf.TabIndex = 22;
            this.lblTurmaProf.Text = "Turma";
            // 
            // cckSenhaProf
            // 
            this.cckSenhaProf.AutoSize = true;
            this.cckSenhaProf.Location = new System.Drawing.Point(372, 266);
            this.cckSenhaProf.Name = "cckSenhaProf";
            this.cckSenhaProf.Size = new System.Drawing.Size(15, 14);
            this.cckSenhaProf.TabIndex = 23;
            this.cckSenhaProf.UseVisualStyleBackColor = true;
            this.cckSenhaProf.CheckedChanged += new System.EventHandler(this.CckSenhaProf_CheckedChanged);
            // 
            // cbxGeneroProf
            // 
            this.cbxGeneroProf.FormattingEnabled = true;
            this.cbxGeneroProf.Location = new System.Drawing.Point(388, 326);
            this.cbxGeneroProf.Name = "cbxGeneroProf";
            this.cbxGeneroProf.Size = new System.Drawing.Size(121, 21);
            this.cbxGeneroProf.TabIndex = 5;
            // 
            // mtxtTelefoneProf
            // 
            this.mtxtTelefoneProf.Location = new System.Drawing.Point(406, 282);
            this.mtxtTelefoneProf.Mask = "(00)00000-0000";
            this.mtxtTelefoneProf.Name = "mtxtTelefoneProf";
            this.mtxtTelefoneProf.Size = new System.Drawing.Size(100, 20);
            this.mtxtTelefoneProf.TabIndex = 24;
            this.mtxtTelefoneProf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // mtxtDataProf
            // 
            this.mtxtDataProf.Location = new System.Drawing.Point(517, 328);
            this.mtxtDataProf.Mask = "00/00/0000";
            this.mtxtDataProf.Name = "mtxtDataProf";
            this.mtxtDataProf.Size = new System.Drawing.Size(100, 20);
            this.mtxtDataProf.TabIndex = 25;
            this.mtxtDataProf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // MenuProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 413);
            this.Controls.Add(this.mtxtDataProf);
            this.Controls.Add(this.mtxtTelefoneProf);
            this.Controls.Add(this.cbxGeneroProf);
            this.Controls.Add(this.cckSenhaProf);
            this.Controls.Add(this.lblTurmaProf);
            this.Controls.Add(this.cbxCodigoTurma);
            this.Controls.Add(this.btnSalvarEditProf);
            this.Controls.Add(this.lblDataProf);
            this.Controls.Add(this.lblGeneroProf);
            this.Controls.Add(this.lblRgProf);
            this.Controls.Add(this.lblCpfProf);
            this.Controls.Add(this.lblTelefoneProf);
            this.Controls.Add(this.lblSenhaProf);
            this.Controls.Add(this.lblSobrenomeProf);
            this.Controls.Add(this.lblNomeProf);
            this.Controls.Add(this.txtRgProf);
            this.Controls.Add(this.txtCpfProf);
            this.Controls.Add(this.txtSenhaProf);
            this.Controls.Add(this.txtSobrenomeProf);
            this.Controls.Add(this.txtNomeProf);
            this.Controls.Add(this.btnListarProf);
            this.Controls.Add(this.btnDeleteProf);
            this.Controls.Add(this.btnEditProf);
            this.Controls.Add(this.lvProf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu de Professores";
            this.Load += new System.EventHandler(this.MenuProfessores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvProf;
        private System.Windows.Forms.Button btnEditProf;
        private System.Windows.Forms.Button btnDeleteProf;
        private System.Windows.Forms.Button btnListarProf;
        private System.Windows.Forms.TextBox txtNomeProf;
        private System.Windows.Forms.TextBox txtSobrenomeProf;
        private System.Windows.Forms.TextBox txtSenhaProf;
        private System.Windows.Forms.TextBox txtCpfProf;
        private System.Windows.Forms.TextBox txtRgProf;
        private System.Windows.Forms.Label lblNomeProf;
        private System.Windows.Forms.Label lblSobrenomeProf;
        private System.Windows.Forms.Label lblSenhaProf;
        private System.Windows.Forms.Label lblTelefoneProf;
        private System.Windows.Forms.Label lblCpfProf;
        private System.Windows.Forms.Label lblRgProf;
        private System.Windows.Forms.Label lblGeneroProf;
        private System.Windows.Forms.Label lblDataProf;
        private System.Windows.Forms.Button btnSalvarEditProf;
        private System.Windows.Forms.ComboBox cbxCodigoTurma;
        private System.Windows.Forms.Label lblTurmaProf;
        private System.Windows.Forms.CheckBox cckSenhaProf;
        private System.Windows.Forms.ComboBox cbxGeneroProf;
        private System.Windows.Forms.MaskedTextBox mtxtTelefoneProf;
        private System.Windows.Forms.MaskedTextBox mtxtDataProf;
    }
}