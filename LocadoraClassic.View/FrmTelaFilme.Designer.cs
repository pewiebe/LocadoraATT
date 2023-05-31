namespace LocadoraClassic.View
{
    partial class FrmTelaFilme
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boxCategoria = new System.Windows.Forms.ComboBox();
            this.boxGenero = new System.Windows.Forms.ComboBox();
            this.textNomeFilme = new System.Windows.Forms.TextBox();
            this.textSinopse = new System.Windows.Forms.TextBox();
            this.boxLocado = new System.Windows.Forms.CheckBox();
            this.textDuracao = new System.Windows.Forms.MaskedTextBox();
            this.boxBanner = new System.Windows.Forms.PictureBox();
            this.btnCadastrasFilme = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textFilme = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.boxBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFilme)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gênero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Filme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Duração";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sinopse";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Banner";
            // 
            // boxCategoria
            // 
            this.boxCategoria.FormattingEnabled = true;
            this.boxCategoria.Location = new System.Drawing.Point(62, 71);
            this.boxCategoria.Name = "boxCategoria";
            this.boxCategoria.Size = new System.Drawing.Size(356, 21);
            this.boxCategoria.TabIndex = 7;
            // 
            // boxGenero
            // 
            this.boxGenero.FormattingEnabled = true;
            this.boxGenero.Location = new System.Drawing.Point(60, 122);
            this.boxGenero.Name = "boxGenero";
            this.boxGenero.Size = new System.Drawing.Size(358, 21);
            this.boxGenero.TabIndex = 8;
            // 
            // textNomeFilme
            // 
            this.textNomeFilme.Location = new System.Drawing.Point(62, 174);
            this.textNomeFilme.Name = "textNomeFilme";
            this.textNomeFilme.Size = new System.Drawing.Size(356, 20);
            this.textNomeFilme.TabIndex = 9;
            // 
            // textSinopse
            // 
            this.textSinopse.Location = new System.Drawing.Point(60, 282);
            this.textSinopse.Multiline = true;
            this.textSinopse.Name = "textSinopse";
            this.textSinopse.Size = new System.Drawing.Size(358, 90);
            this.textSinopse.TabIndex = 11;
            // 
            // boxLocado
            // 
            this.boxLocado.AutoSize = true;
            this.boxLocado.Location = new System.Drawing.Point(60, 388);
            this.boxLocado.Name = "boxLocado";
            this.boxLocado.Size = new System.Drawing.Size(62, 17);
            this.boxLocado.TabIndex = 12;
            this.boxLocado.Text = "Locado";
            this.boxLocado.UseVisualStyleBackColor = true;
            // 
            // textDuracao
            // 
            this.textDuracao.Location = new System.Drawing.Point(62, 217);
            this.textDuracao.Mask = "90:00";
            this.textDuracao.Name = "textDuracao";
            this.textDuracao.Size = new System.Drawing.Size(356, 20);
            this.textDuracao.TabIndex = 13;
            this.textDuracao.ValidatingType = typeof(System.DateTime);
            // 
            // boxBanner
            // 
            this.boxBanner.Location = new System.Drawing.Point(442, 71);
            this.boxBanner.Name = "boxBanner";
            this.boxBanner.Size = new System.Drawing.Size(273, 301);
            this.boxBanner.TabIndex = 14;
            this.boxBanner.TabStop = false;
            // 
            // btnCadastrasFilme
            // 
            this.btnCadastrasFilme.Location = new System.Drawing.Point(65, 674);
            this.btnCadastrasFilme.Name = "btnCadastrasFilme";
            this.btnCadastrasFilme.Size = new System.Drawing.Size(653, 23);
            this.btnCadastrasFilme.TabIndex = 15;
            this.btnCadastrasFilme.Text = "Cadastrar";
            this.btnCadastrasFilme.UseVisualStyleBackColor = true;
            this.btnCadastrasFilme.Click += new System.EventHandler(this.btnCadastrasFilme_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(189, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 37);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cadastrar Filme";
            // 
            // textFilme
            // 
            this.textFilme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.textFilme.Location = new System.Drawing.Point(37, 411);
            this.textFilme.Name = "textFilme";
            this.textFilme.Size = new System.Drawing.Size(736, 252);
            this.textFilme.TabIndex = 17;
            this.textFilme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.textFilme_CellContentClick);
            // 
            // FrmTelaFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 709);
            this.Controls.Add(this.textFilme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCadastrasFilme);
            this.Controls.Add(this.boxBanner);
            this.Controls.Add(this.textDuracao);
            this.Controls.Add(this.boxLocado);
            this.Controls.Add(this.textSinopse);
            this.Controls.Add(this.textNomeFilme);
            this.Controls.Add(this.boxGenero);
            this.Controls.Add(this.boxCategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTelaFilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTelaFilme";
            this.Load += new System.EventHandler(this.FrmTelaFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFilme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox boxCategoria;
        private System.Windows.Forms.ComboBox boxGenero;
        private System.Windows.Forms.TextBox textNomeFilme;
        private System.Windows.Forms.TextBox textSinopse;
        private System.Windows.Forms.CheckBox boxLocado;
        private System.Windows.Forms.MaskedTextBox textDuracao;
        private System.Windows.Forms.PictureBox boxBanner;
        private System.Windows.Forms.Button btnCadastrasFilme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView textFilme;
    }
}