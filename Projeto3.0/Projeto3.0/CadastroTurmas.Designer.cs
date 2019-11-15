namespace Projeto3._0
{
    partial class CadastroTurmas
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
            this.lblCodTurma = new System.Windows.Forms.Label();
            this.btnCodTurma = new System.Windows.Forms.Button();
            this.btbSaveTurma = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxDiasAula = new System.Windows.Forms.ComboBox();
            this.txtHorarioTurma = new System.Windows.Forms.TextBox();
            this.txtTipoTurma = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCodTurma
            // 
            this.lblCodTurma.AutoSize = true;
            this.lblCodTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodTurma.Location = new System.Drawing.Point(146, 87);
            this.lblCodTurma.Name = "lblCodTurma";
            this.lblCodTurma.Size = new System.Drawing.Size(46, 17);
            this.lblCodTurma.TabIndex = 27;
            this.lblCodTurma.Text = "label6";
            this.lblCodTurma.Visible = false;
            // 
            // btnCodTurma
            // 
            this.btnCodTurma.Location = new System.Drawing.Point(39, 87);
            this.btnCodTurma.Name = "btnCodTurma";
            this.btnCodTurma.Size = new System.Drawing.Size(96, 23);
            this.btnCodTurma.TabIndex = 26;
            this.btnCodTurma.Text = "Gerar Código";
            this.btnCodTurma.UseVisualStyleBackColor = true;
            this.btnCodTurma.Click += new System.EventHandler(this.BtnCodTurma_Click);
            // 
            // btbSaveTurma
            // 
            this.btbSaveTurma.Location = new System.Drawing.Point(293, 218);
            this.btbSaveTurma.Name = "btbSaveTurma";
            this.btbSaveTurma.Size = new System.Drawing.Size(75, 23);
            this.btbSaveTurma.TabIndex = 24;
            this.btbSaveTurma.Text = "Salvar";
            this.btbSaveTurma.UseVisualStyleBackColor = true;
            this.btbSaveTurma.Click += new System.EventHandler(this.BtbSaveTurma_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 18);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cadastro de novas turmas.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tipo de aula: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Dias das aulas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Horario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Categoria da turma:";
            // 
            // cbxDiasAula
            // 
            this.cbxDiasAula.FormattingEnabled = true;
            this.cbxDiasAula.Location = new System.Drawing.Point(39, 161);
            this.cbxDiasAula.Name = "cbxDiasAula";
            this.cbxDiasAula.Size = new System.Drawing.Size(121, 21);
            this.cbxDiasAula.TabIndex = 29;
            this.cbxDiasAula.Text = "[Selecione]";
            // 
            // txtHorarioTurma
            // 
            this.txtHorarioTurma.Location = new System.Drawing.Point(268, 86);
            this.txtHorarioTurma.Name = "txtHorarioTurma";
            this.txtHorarioTurma.Size = new System.Drawing.Size(100, 20);
            this.txtHorarioTurma.TabIndex = 30;
            // 
            // txtTipoTurma
            // 
            this.txtTipoTurma.Location = new System.Drawing.Point(268, 161);
            this.txtTipoTurma.Name = "txtTipoTurma";
            this.txtTipoTurma.Size = new System.Drawing.Size(100, 20);
            this.txtTipoTurma.TabIndex = 31;
            // 
            // CadastroTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 274);
            this.Controls.Add(this.txtTipoTurma);
            this.Controls.Add(this.txtHorarioTurma);
            this.Controls.Add(this.cbxDiasAula);
            this.Controls.Add(this.lblCodTurma);
            this.Controls.Add(this.btnCodTurma);
            this.Controls.Add(this.btbSaveTurma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CadastroTurmas";
            this.Text = "CadastroTurmas";
            this.Load += new System.EventHandler(this.CadastroTurmas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCodTurma;
        private System.Windows.Forms.Button btnCodTurma;
        private System.Windows.Forms.Button btbSaveTurma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxDiasAula;
        private System.Windows.Forms.TextBox txtHorarioTurma;
        private System.Windows.Forms.TextBox txtTipoTurma;
    }
}