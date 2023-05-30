using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocadoraClassic.VO;
using LocadoraClassic.DAL;

namespace LocadoraClassic.View
{
    public partial class FrmTelaGenero : Form
    {
        GeneroDAL GeneroDAL = new GeneroDAL();
        int id = 0;
        Genero genero = new Genero();
        
        public FrmTelaGenero()
        {
            InitializeComponent();
            textGenero.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            textGenero.CellDoubleClick += textGenero_CellDoubleClick;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //objeto VO
            Genero genero = new Genero();
            //objeto DAL
            GeneroDAL generoDAL = new GeneroDAL();
            //Pegar o valor da caixinha e colocar na propriedade Nome
            genero.Nome = txtGenero.Text;

            //INSERIR NO BANCO DE DADOS
            generoDAL.InserirGenero(genero);

            //Limpar a caixa
            txtGenero.Text = "";
            CarregarGrid();
            MessageBox.Show("Dados inseridos com sucesso!");


        }

        private void textGenero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textGenero.DataSource = GeneroDAL.ObterGeneros().ToList();

        }

        private void FrmTelaGenero_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        public void CarregarGrid()
        {
            textGenero.DataSource = GeneroDAL.ObterGeneros().ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ETAPA 1 - SELECIONAR O ID DA TABELA
            int id = 0;
            // Verifica se há alguma linha selecionada no DataGridView
            if (textGenero.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = textGenero.SelectedRows[0];

                // Obtém o valor do campo "id" da célula selecionada
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo
                MessageBox.Show("O valor do campo 'id' é: " + id.ToString());
            }

            //ETAPA 2 - ENVIAR O ID PARA DELETE

            GeneroDAL generoDAL = new GeneroDAL();
            generoDAL.ExcluirGenero(id);
            CarregarGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            genero.Nome = txtGenero.Text;
            genero.Id = id;
            GeneroDAL.AtualizarGenero(genero);
            txtGenero.Text = "";
            CarregarGrid();

        }

        private void textGenero_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtém a linha em que ocorreu o duplo clique
                DataGridViewRow row = textGenero.Rows[e.RowIndex];

                // Seleciona a linha inteira
                row.Selected = true;
            }

            //ETAPA 1 - SELECIONAR O ID DA TABELA

            // Verifica se há alguma linha selecionada no DataGridView
            if (textGenero.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = textGenero.SelectedRows[0];

                // Obtém o valor do campo "id" da célula selecionada
                id = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                string nome = selectedRow.Cells["Nome"].Value.ToString();
                txtGenero.Text = nome;
                // Faça o que precisar com o valor do campo "id"
                // Por exemplo, exiba-o em uma caixa de diálogo



            }


        }

        private void txtGenero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
