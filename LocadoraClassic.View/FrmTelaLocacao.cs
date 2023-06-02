using LocadoraClassic.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocadoraClassic.View
{
    public partial class FrmTelaLocacao : Form
    {
        LocacaoDAL locacaoDAL = new LocacaoDAL();
        ClienteDAL clienteDAL = new ClienteDAL();
        CategoriaDAL categoriaDAL = new CategoriaDAL();
        GeneroDAL generoDAL = new GeneroDAL();
        FilmeDAL filmeDAL = new FilmeDAL();
        int idSelecionadoCat;
        int idSelecionadoGen;
        public FrmTelaLocacao()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            string cpf = BuscarCliente.Text;


        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
