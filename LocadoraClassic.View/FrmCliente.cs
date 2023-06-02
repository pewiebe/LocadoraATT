using LocadoraClassic.DAL;
using LocadoraClassic.VO;
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
    public partial class FrmCliente : Form
    {
        ClienteDAL clienteDAL = new ClienteDAL();
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtGridCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.Nome = txtGridCliente.Text;
            cliente.Nome = TxtNomeCliente.Text;
            cliente.Endereco = TxtEnderecoCliente.Text;
            cliente.Numero = TxtWppCliente.Text;
            cliente.RG = TxtRgCliente.Text;
            cliente.CPF = TxtCpfCliente.Text;

            clienteDAL.InserirCliente(cliente);

            TxtNomeCliente.Text = "";
            txtGridCliente.Text = "";
            TxtEnderecoCliente.Text = "";
            TxtWppCliente.Text = "";
            TxtRgCliente.Text = "";
            TxtCpfCliente.Text = "";

            CarregarGrid();
            MessageBox.Show("Dados inseridos com sucesso!");
        }
        private void CarregarGrid()
        {
            txtGridCliente.DataSource = clienteDAL.ObterClientes().ToList();
        }
        private void TxtNomeCliente_TextChanged(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void TxtNomeCliente_TextChanged_1(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void TxtEnderecoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ETAPA 1 - SELECIONAR O ID DA TABELA
            int id = 0;
            // Verifica se há alguma linha selecionada no DataGridView
            if (txtGridCliente.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = txtGridCliente.SelectedRows[0];

                // Obtém o valor do campo "id" da célula selecionada
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo
                MessageBox.Show("O valor do campo 'id' é: " + id.ToString());

                ClienteDAL clienteDAL = new ClienteDAL();
                clienteDAL.ExcluirCliente(id);
                CarregarGrid();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //ETAPA 1 - SELECIONAR O ID DA TABELA
            int id = 0;
            // Verifica se há alguma linha selecionada no DataGridView
            if (txtGridCliente.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = txtGridCliente.SelectedRows[0];

                // Obtém o valor do campo "id" da célula selecionada
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo
                MessageBox.Show("O valor do campo 'id' é: " + id.ToString());

                ClienteDAL clienteDAL = new ClienteDAL();
                clienteDAL.ExcluirCliente(id);
                CarregarGrid();
            }
        }
    }
}
