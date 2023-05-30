using LocadoraClassic.DAL;
using LocadoraClassic.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LocadoraClassic.View
{

    public partial class FrmTelaFilme : Form
    {
        FilmeDAL filmeDAL = new FilmeDAL();
        CategoriaDAL categoriaDAL = new CategoriaDAL();
        GeneroDAL generoDAL = new GeneroDAL(); 

        public FrmTelaFilme()
        {
            InitializeComponent();
            CarregarGrid();
            PreencherComboBoxCategorias();
            PreencherComboBoxGeneros();
        }

        private void PreencherComboBoxCategorias()
        {
            // Obtenha a lista de gêneros da GeneroDAL
            List<Categoria> categorias = categoriaDAL.ObterCategorias();

            // Limpe o ComboBox antes de adicionar os itens
            boxCategoria.Items.Clear();

            // Adicione os gêneros ao ComboBox
            foreach (Categoria categoria in categorias)
            {
                boxCategoria.Items.Add(categoria.Nome);
            }
        }
        // Crie um método para preencher o ComboBox com as categorias
        private void PreencherComboBoxGeneros()
        {
            // Obtenha a lista de gêneros da GeneroDAL
            List<Genero> generos = generoDAL.ObterGeneros();

            // Limpe o ComboBox antes de adicionar os itens
            boxGenero.Items.Clear();

            // Adicione os gêneros ao ComboBox
            foreach (Genero genero in generos)
            {
                boxGenero.Items.Add(genero.Nome);
            }
        }

            private void btnCadastrasFilme_Click(object sender, EventArgs e)
        {
            // Crie um novo objeto Filme
            Filme filme = new Filme();

            // Defina os valores das propriedades do filme com base nos controles do formulário
            filme.Nome = textNomeFilme.Text;
            TimeSpan duracao = TimeSpan.Parse(textDuracao.Text);
            string duracaoFormatada = duracao.ToString(@"hh\:mm");
            filme.Duracao = TimeSpan.Parse(duracaoFormatada);
            filme.Sinopse = textSinopse.Text;

            // Obtenha o objeto Categoria selecionado no ComboBox
            if (boxCategoria.SelectedItem is Categoria categoria)
            {
                filme.Categoria = categoria;
            }

            // Obtenha o objeto Genero selecionado no ComboBox
            if (boxGenero.SelectedItem is Genero genero)
            {
                filme.Genero = genero;
            }

            // Verifique se o filme está locado
            filme.Locado = boxLocado.Checked;

            // Inserir o filme no banco de dados
            filmeDAL.InserirFilme(filme);

            // Limpar os campos do formulário
            textNomeFilme.Text = "";
            textDuracao.Text = "";
            textSinopse.Text = "";
            boxGenero.SelectedIndex = -1;
            boxCategoria.SelectedIndex = -1;
            boxLocado.Checked = false;

            MessageBox.Show("Dados inseridos com sucesso!");

            // Atualizar o DataGridView
            CarregarGrid();


        }

        private void textFilme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textFilme.DataSource = filmeDAL.ObterFilmes().ToList();
        }

        private void FrmTelaFilme_Load(object sender, EventArgs e)
        {

        }
        public void CarregarGrid()
        {
            textFilme.DataSource = filmeDAL.ObterFilmes().ToList();
        }
    }
}
