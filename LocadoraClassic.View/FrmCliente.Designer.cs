namespace LocadoraClassic.View
{
    partial class FrmCliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.TxtWppCliente = new System.Windows.Forms.MaskedTextBox();
            this.TxtCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.TxtRgCliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGridCliente = new System.Windows.Forms.DataGridView();
            this.TxtNomeCliente = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtGridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // TxtEnderecoCliente
            // 
            resources.ApplyResources(this.TxtEnderecoCliente, "TxtEnderecoCliente");
            this.TxtEnderecoCliente.Name = "TxtEnderecoCliente";
            this.TxtEnderecoCliente.TextChanged += new System.EventHandler(this.TxtEnderecoCliente_TextChanged);
            // 
            // TxtWppCliente
            // 
            resources.ApplyResources(this.TxtWppCliente, "TxtWppCliente");
            this.TxtWppCliente.Name = "TxtWppCliente";
            // 
            // TxtCpfCliente
            // 
            resources.ApplyResources(this.TxtCpfCliente, "TxtCpfCliente");
            this.TxtCpfCliente.Name = "TxtCpfCliente";
            // 
            // TxtRgCliente
            // 
            resources.ApplyResources(this.TxtRgCliente, "TxtRgCliente");
            this.TxtRgCliente.Name = "TxtRgCliente";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txtGridCliente
            // 
            this.txtGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.txtGridCliente, "txtGridCliente");
            this.txtGridCliente.Name = "txtGridCliente";
            this.txtGridCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.txtGridCliente_CellContentClick);
            // 
            // TxtNomeCliente
            // 
            resources.ApplyResources(this.TxtNomeCliente, "TxtNomeCliente");
            this.TxtNomeCliente.Name = "TxtNomeCliente";
            this.TxtNomeCliente.TextChanged += new System.EventHandler(this.TxtNomeCliente_TextChanged_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // FrmCliente
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtNomeCliente);
            this.Controls.Add(this.txtGridCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtRgCliente);
            this.Controls.Add(this.TxtCpfCliente);
            this.Controls.Add(this.TxtWppCliente);
            this.Controls.Add(this.TxtEnderecoCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCliente";
            ((System.ComponentModel.ISupportInitialize)(this.txtGridCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEnderecoCliente;
        private System.Windows.Forms.MaskedTextBox TxtWppCliente;
        private System.Windows.Forms.MaskedTextBox TxtCpfCliente;
        private System.Windows.Forms.TextBox TxtRgCliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView txtGridCliente;
        private System.Windows.Forms.TextBox TxtNomeCliente;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button2;
    }
}