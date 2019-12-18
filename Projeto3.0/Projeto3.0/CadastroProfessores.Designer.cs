namespace Projeto3._0
{
    partial class CadastroProfessores
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
            this.txtNovoNome = new System.Windows.Forms.TextBox();
            this.txtNovoSobrenome = new System.Windows.Forms.TextBox();
            this.lblNomeProf = new System.Windows.Forms.Label();
            this.lblSobrenomeProf = new System.Windows.Forms.Label();
            this.lblTelefoneProf = new System.Windows.Forms.Label();
            this.mtxtNovoTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblCPFProf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNovoRg = new System.Windows.Forms.TextBox();
            this.mtxtNovoData = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxGeneroProf = new System.Windows.Forms.ComboBox();
            this.lblGeneroProf = new System.Windows.Forms.Label();
            this.btnSalvarProf = new System.Windows.Forms.Button();
            this.btnCancelarProf = new System.Windows.Forms.Button();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.lblSenhaProf = new System.Windows.Forms.Label();
            this.cbxTurmasOn = new System.Windows.Forms.ComboBox();
            this.lblCodigoTurmaProf = new System.Windows.Forms.Label();
            this.txtNovoCpf = new System.Windows.Forms.TextBox();
            this.txtNomeTurma = new System.Windows.Forms.TextBox();
            this.cckSenhaProf = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtNovoNome
            // 
            this.txtNovoNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNovoNome.Location = new System.Drawing.Point(40, 54);
            this.txtNovoNome.Name = "txtNovoNome";
            this.txtNovoNome.Size = new System.Drawing.Size(100, 20);
            this.txtNovoNome.TabIndex = 0;
            // 
            // txtNovoSobrenome
            // 
            this.txtNovoSobrenome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNovoSobrenome.Location = new System.Drawing.Point(183, 54);
            this.txtNovoSobrenome.Name = "txtNovoSobrenome";
            this.txtNovoSobrenome.Size = new System.Drawing.Size(100, 20);
            this.txtNovoSobrenome.TabIndex = 1;
            // 
            // lblNomeProf
            // 
            this.lblNomeProf.AutoSize = true;
            this.lblNomeProf.Location = new System.Drawing.Point(37, 38);
            this.lblNomeProf.Name = "lblNomeProf";
            this.lblNomeProf.Size = new System.Drawing.Size(35, 13);
            this.lblNomeProf.TabIndex = 8;
            this.lblNomeProf.Text = "Nome";
            // 
            // lblSobrenomeProf
            // 
            this.lblSobrenomeProf.AutoSize = true;
            this.lblSobrenomeProf.Location = new System.Drawing.Point(180, 38);
            this.lblSobrenomeProf.Name = "lblSobrenomeProf";
            this.lblSobrenomeProf.Size = new System.Drawing.Size(61, 13);
            this.lblSobrenomeProf.TabIndex = 9;
            this.lblSobrenomeProf.Text = "Sobrenome";
            // 
            // lblTelefoneProf
            // 
            this.lblTelefoneProf.AutoSize = true;
            this.lblTelefoneProf.Location = new System.Drawing.Point(180, 118);
            this.lblTelefoneProf.Name = "lblTelefoneProf";
            this.lblTelefoneProf.Size = new System.Drawing.Size(49, 13);
            this.lblTelefoneProf.TabIndex = 10;
            this.lblTelefoneProf.Text = "Telefone";
            // 
            // mtxtNovoTelefone
            // 
            this.mtxtNovoTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtNovoTelefone.Location = new System.Drawing.Point(183, 134);
            this.mtxtNovoTelefone.Mask = "(00)00000-0000";
            this.mtxtNovoTelefone.Name = "mtxtNovoTelefone";
            this.mtxtNovoTelefone.Size = new System.Drawing.Size(100, 20);
            this.mtxtNovoTelefone.TabIndex = 3;
            this.mtxtNovoTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // lblCPFProf
            // 
            this.lblCPFProf.AutoSize = true;
            this.lblCPFProf.Location = new System.Drawing.Point(40, 198);
            this.lblCPFProf.Name = "lblCPFProf";
            this.lblCPFProf.Size = new System.Drawing.Size(27, 13);
            this.lblCPFProf.TabIndex = 12;
            this.lblCPFProf.Text = "CPF";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "RG";
            // 
            // txtNovoRg
            // 
            this.txtNovoRg.Location = new System.Drawing.Point(183, 214);
            this.txtNovoRg.Name = "txtNovoRg";
            this.txtNovoRg.Size = new System.Drawing.Size(100, 20);
            this.txtNovoRg.TabIndex = 5;
            // 
            // mtxtNovoData
            // 
            this.mtxtNovoData.Location = new System.Drawing.Point(183, 283);
            this.mtxtNovoData.Mask = "99/99/9999";
            this.mtxtNovoData.Name = "mtxtNovoData";
            this.mtxtNovoData.Size = new System.Drawing.Size(71, 20);
            this.mtxtNovoData.TabIndex = 7;
            this.mtxtNovoData.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nascimento";
            // 
            // cbxGeneroProf
            // 
            this.cbxGeneroProf.FormattingEnabled = true;
            this.cbxGeneroProf.Location = new System.Drawing.Point(40, 282);
            this.cbxGeneroProf.Name = "cbxGeneroProf";
            this.cbxGeneroProf.Size = new System.Drawing.Size(121, 21);
            this.cbxGeneroProf.TabIndex = 6;
            this.cbxGeneroProf.Text = "[Selecione]";
            // 
            // lblGeneroProf
            // 
            this.lblGeneroProf.AutoSize = true;
            this.lblGeneroProf.Location = new System.Drawing.Point(40, 265);
            this.lblGeneroProf.Name = "lblGeneroProf";
            this.lblGeneroProf.Size = new System.Drawing.Size(42, 13);
            this.lblGeneroProf.TabIndex = 19;
            this.lblGeneroProf.Text = "Gênero";
            // 
            // btnSalvarProf
            // 
            this.btnSalvarProf.Location = new System.Drawing.Point(40, 391);
            this.btnSalvarProf.Name = "btnSalvarProf";
            this.btnSalvarProf.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarProf.TabIndex = 8;
            this.btnSalvarProf.Text = "Salvar";
            this.btnSalvarProf.UseVisualStyleBackColor = true;
            this.btnSalvarProf.Click += new System.EventHandler(this.BtnSalvarProf_Click);
            // 
            // btnCancelarProf
            // 
            this.btnCancelarProf.Location = new System.Drawing.Point(128, 391);
            this.btnCancelarProf.Name = "btnCancelarProf";
            this.btnCancelarProf.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarProf.TabIndex = 21;
            this.btnCancelarProf.Text = "Cancelar";
            this.btnCancelarProf.UseVisualStyleBackColor = true;
            this.btnCancelarProf.Click += new System.EventHandler(this.BtnCancelarProf_Click);
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Location = new System.Drawing.Point(40, 134);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(100, 20);
            this.txtNovaSenha.TabIndex = 2;
            this.txtNovaSenha.UseSystemPasswordChar = true;
            // 
            // lblSenhaProf
            // 
            this.lblSenhaProf.AutoSize = true;
            this.lblSenhaProf.Location = new System.Drawing.Point(40, 117);
            this.lblSenhaProf.Name = "lblSenhaProf";
            this.lblSenhaProf.Size = new System.Drawing.Size(38, 13);
            this.lblSenhaProf.TabIndex = 23;
            this.lblSenhaProf.Text = "Senha";
            // 
            // cbxTurmasOn
            // 
            this.cbxTurmasOn.FormattingEnabled = true;
            this.cbxTurmasOn.Location = new System.Drawing.Point(40, 343);
            this.cbxTurmasOn.Name = "cbxTurmasOn";
            this.cbxTurmasOn.Size = new System.Drawing.Size(121, 21);
            this.cbxTurmasOn.TabIndex = 8;
            this.cbxTurmasOn.Text = "[Selecione]";
            this.cbxTurmasOn.SelectedIndexChanged += new System.EventHandler(this.CbxTurmasOn_SelectedIndexChanged);
            // 
            // lblCodigoTurmaProf
            // 
            this.lblCodigoTurmaProf.AutoSize = true;
            this.lblCodigoTurmaProf.Location = new System.Drawing.Point(43, 327);
            this.lblCodigoTurmaProf.Name = "lblCodigoTurmaProf";
            this.lblCodigoTurmaProf.Size = new System.Drawing.Size(37, 13);
            this.lblCodigoTurmaProf.TabIndex = 25;
            this.lblCodigoTurmaProf.Text = "Turma";
            // 
            // txtNovoCpf
            // 
            this.txtNovoCpf.Location = new System.Drawing.Point(43, 213);
            this.txtNovoCpf.Name = "txtNovoCpf";
            this.txtNovoCpf.Size = new System.Drawing.Size(100, 20);
            this.txtNovoCpf.TabIndex = 4;
            // 
            // txtNomeTurma
            // 
            this.txtNomeTurma.Location = new System.Drawing.Point(183, 344);
            this.txtNomeTurma.Name = "txtNomeTurma";
            this.txtNomeTurma.Size = new System.Drawing.Size(100, 20);
            this.txtNomeTurma.TabIndex = 9;
            // 
            // cckSenhaProf
            // 
            this.cckSenhaProf.AutoSize = true;
            this.cckSenhaProf.Location = new System.Drawing.Point(146, 137);
            this.cckSenhaProf.Name = "cckSenhaProf";
            this.cckSenhaProf.Size = new System.Drawing.Size(15, 14);
            this.cckSenhaProf.TabIndex = 26;
            this.cckSenhaProf.UseVisualStyleBackColor = true;
            this.cckSenhaProf.CheckedChanged += new System.EventHandler(this.cckSenhaProf_CheckedChanged);
            // 
            // CadastroProfessores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.cckSenhaProf);
            this.Controls.Add(this.txtNomeTurma);
            this.Controls.Add(this.txtNovoCpf);
            this.Controls.Add(this.lblCodigoTurmaProf);
            this.Controls.Add(this.cbxTurmasOn);
            this.Controls.Add(this.lblSenhaProf);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.btnCancelarProf);
            this.Controls.Add(this.btnSalvarProf);
            this.Controls.Add(this.lblGeneroProf);
            this.Controls.Add(this.cbxGeneroProf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtxtNovoData);
            this.Controls.Add(this.txtNovoRg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCPFProf);
            this.Controls.Add(this.mtxtNovoTelefone);
            this.Controls.Add(this.lblTelefoneProf);
            this.Controls.Add(this.lblSobrenomeProf);
            this.Controls.Add(this.lblNomeProf);
            this.Controls.Add(this.txtNovoSobrenome);
            this.Controls.Add(this.txtNovoNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CadastroProfessores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Professores";
            this.Load += new System.EventHandler(this.CadastroProfessores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNovoNome;
        private System.Windows.Forms.TextBox txtNovoSobrenome;
        private System.Windows.Forms.Label lblNomeProf;
        private System.Windows.Forms.Label lblSobrenomeProf;
        private System.Windows.Forms.Label lblTelefoneProf;
        private System.Windows.Forms.MaskedTextBox mtxtNovoTelefone;
        private System.Windows.Forms.Label lblCPFProf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNovoRg;
        private System.Windows.Forms.MaskedTextBox mtxtNovoData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxGeneroProf;
        private System.Windows.Forms.Label lblGeneroProf;
        private System.Windows.Forms.Button btnSalvarProf;
        private System.Windows.Forms.Button btnCancelarProf;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Label lblSenhaProf;
        private System.Windows.Forms.ComboBox cbxTurmasOn;
        private System.Windows.Forms.Label lblCodigoTurmaProf;
        private System.Windows.Forms.TextBox txtNovoCpf;
        private System.Windows.Forms.TextBox txtNomeTurma;
        private System.Windows.Forms.CheckBox cckSenhaProf;
    }
}