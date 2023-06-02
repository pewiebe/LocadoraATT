namespace LocadoraClassic.View
{
    partial class FrmTelaGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaGenero));
            this.label1 = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textGenero = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAltGenero = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(326, 122);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(415, 20);
            this.txtGenero.TabIndex = 1;
            this.txtGenero.TextChanged += new System.EventHandler(this.txtGenero_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(326, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cadastrar Gênero";
            // 
            // textGenero
            // 
            this.textGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.textGenero.Location = new System.Drawing.Point(192, 194);
            this.textGenero.Name = "textGenero";
            this.textGenero.Size = new System.Drawing.Size(737, 374);
            this.textGenero.TabIndex = 4;
            this.textGenero.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.textGenero_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(476, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAltGenero
            // 
            this.txtAltGenero.BackColor = System.Drawing.Color.White;
            this.txtAltGenero.Location = new System.Drawing.Point(615, 148);
            this.txtAltGenero.Name = "txtAltGenero";
            this.txtAltGenero.Size = new System.Drawing.Size(133, 23);
            this.txtAltGenero.TabIndex = 6;
            this.txtAltGenero.Text = "Alterar";
            this.txtAltGenero.UseVisualStyleBackColor = false;
            this.txtAltGenero.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmTelaGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1146, 698);
            this.Controls.Add(this.txtAltGenero);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTelaGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Gênero";
            this.Load += new System.EventHandler(this.FrmTelaGenero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView textGenero;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button txtAltGenero;
    }
}