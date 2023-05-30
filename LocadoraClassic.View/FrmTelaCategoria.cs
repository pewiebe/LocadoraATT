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
    public partial class FrmTelaCategoria : Form
    {
        CategoriaDAL CategoriaDAL = new CategoriaDAL();
        public FrmTelaCategoria()
        {
            InitializeComponent();
            CarregarGrid();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmTelaCategoria_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNomeSamuel_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                Categoria categoria = new Categoria();


                categoria.Nome = txtNomeSamuel.Text;
                categoria.ValordaDiaria = txtValor.Text;


                CategoriaDAL.InserirCategoria(categoria);

                CarregarGrid();
                txtNomeSamuel.Text = "";
                txtValor.Text = "";
                MessageBox.Show("Dados inseridos com sucesso!");


            }

        }
        private void CarregarGrid()
        {
            txtGridCategoria.DataSource = CategoriaDAL.ObterCategorias().ToList();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //ETAPA 1 - SELECIONAR O ID DA TABELA
            int id = 0;
            // Verifica se há alguma linha selecionada no DataGridView
            if (txtGridCategoria.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = txtGridCategoria.SelectedRows[0];

                // Obtém o valor do campo "id" da célula selecionada
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo
                MessageBox.Show("O valor do campo 'id' é: " + id.ToString());
            }

            //ETAPA 2 - ENVIAR O ID PARA DELETE

           CategoriaDAL categoria = new CategoriaDAL();
           CategoriaDAL.ExcluirCategoria(id);
            CarregarGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
