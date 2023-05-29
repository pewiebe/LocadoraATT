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
            this.BoxCategoria = new System.Windows.Forms.ComboBox();
            this.BoxGenero = new System.Windows.Forms.ComboBox();
            this.TxtFilme1 = new System.Windows.Forms.TextBox();
            this.TxtSinopse = new System.Windows.Forms.TextBox();
            this.BoxLocado = new System.Windows.Forms.CheckBox();
            this.TxtDuracao = new System.Windows.Forms.MaskedTextBox();
            this.BoxBanner = new System.Windows.Forms.PictureBox();
            this.BtnCadastrarFilme = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BoxBanner)).BeginInit();
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
            // BoxCategoria
            // 
            this.BoxCategoria.FormattingEnabled = true;
            this.BoxCategoria.Location = new System.Drawing.Point(62, 71);
            this.BoxCategoria.Name = "BoxCategoria";
            this.BoxCategoria.Size = new System.Drawing.Size(356, 21);
            this.BoxCategoria.TabIndex = 7;
            // 
            // BoxGenero
            // 
            this.BoxGenero.FormattingEnabled = true;
            this.BoxGenero.Location = new System.Drawing.Point(60, 122);
            this.BoxGenero.Name = "BoxGenero";
            this.BoxGenero.Size = new System.Drawing.Size(358, 21);
            this.BoxGenero.TabIndex = 8;
            // 
            // TxtFilme1
            // 
            this.TxtFilme1.Location = new System.Drawing.Point(62, 174);
            this.TxtFilme1.Name = "TxtFilme1";
            this.TxtFilme1.Size = new System.Drawing.Size(356, 20);
            this.TxtFilme1.TabIndex = 9;
            // 
            // TxtSinopse
            // 
            this.TxtSinopse.Location = new System.Drawing.Point(60, 282);
            this.TxtSinopse.Multiline = true;
            this.TxtSinopse.Name = "TxtSinopse";
            this.TxtSinopse.Size = new System.Drawing.Size(358, 90);
            this.TxtSinopse.TabIndex = 11;
            // 
            // BoxLocado
            // 
            this.BoxLocado.AutoSize = true;
            this.BoxLocado.Location = new System.Drawing.Point(60, 388);
            this.BoxLocado.Name = "BoxLocado";
            this.BoxLocado.Size = new System.Drawing.Size(62, 17);
            this.BoxLocado.TabIndex = 12;
            this.BoxLocado.Text = "Locado";
            this.BoxLocado.UseVisualStyleBackColor = true;
            // 
            // TxtDuracao
            // 
            this.TxtDuracao.Location = new System.Drawing.Point(62, 217);
            this.TxtDuracao.Mask = "90:00";
            this.TxtDuracao.Name = "TxtDuracao";
            this.TxtDuracao.Size = new System.Drawing.Size(356, 20);
            this.TxtDuracao.TabIndex = 13;
            this.TxtDuracao.ValidatingType = typeof(System.DateTime);
            // 
            // BoxBanner
            // 
            this.BoxBanner.Location = new System.Drawing.Point(442, 71);
            this.BoxBanner.Name = "BoxBanner";
            this.BoxBanner.Size = new System.Drawing.Size(273, 301);
            this.BoxBanner.TabIndex = 14;
            this.BoxBanner.TabStop = false;
            // 
            // BtnCadastrarFilme
            // 
            this.BtnCadastrarFilme.Location = new System.Drawing.Point(62, 412);
            this.BtnCadastrarFilme.Name = "BtnCadastrarFilme";
            this.BtnCadastrarFilme.Size = new System.Drawing.Size(653, 23);
            this.BtnCadastrarFilme.TabIndex = 15;
            this.BtnCadastrarFilme.Text = "Cadastrar";
            this.BtnCadastrarFilme.UseVisualStyleBackColor = true;
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
            // FrmTelaFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnCadastrarFilme);
            this.Controls.Add(this.BoxBanner);
            this.Controls.Add(this.TxtDuracao);
            this.Controls.Add(this.BoxLocado);
            this.Controls.Add(this.TxtSinopse);
            this.Controls.Add(this.TxtFilme1);
            this.Controls.Add(this.BoxGenero);
            this.Controls.Add(this.BoxCategoria);
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
            ((System.ComponentModel.ISupportInitialize)(this.BoxBanner)).EndInit();
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
        private System.Windows.Forms.ComboBox BoxCategoria;
        private System.Windows.Forms.ComboBox BoxGenero;
        private System.Windows.Forms.TextBox TxtFilme1;
        private System.Windows.Forms.TextBox TxtSinopse;
        private System.Windows.Forms.CheckBox BoxLocado;
        private System.Windows.Forms.MaskedTextBox TxtDuracao;
        private System.Windows.Forms.PictureBox BoxBanner;
        private System.Windows.Forms.Button BtnCadastrarFilme;
        private System.Windows.Forms.Label label6;
    }
}