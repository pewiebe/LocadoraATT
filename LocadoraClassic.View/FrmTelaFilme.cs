﻿using LocadoraClassic.DAL;
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
        int idCategoria;

        public FrmTelaFilme()
        {
            InitializeComponent();
            PreencherComboBoxCategorias();
            PreencherComboBoxGeneros();
            CarregarGrid();
        }

        private void PreencherComboBoxCategorias()
        {
            List<Categoria> categorias = categoriaDAL.ObterCategorias();
            boxCategoria.Items.Clear();
            foreach (Categoria categoria in categorias)
            {
                boxCategoria.Items.Add(categoria.Nome);
                
            }
            boxCategoria.ValueMember = "Id";
            boxCategoria.DisplayMember = "Nome";
        }
        // Crie um método para preencher o ComboBox com as categorias
        private void PreencherComboBoxGeneros()
        {
            // Obtenha a lista de gêneros da GeneroDAL
            List<Genero> generos = generoDAL.ObterGeneros();
            boxGenero.Items.Clear();
            foreach (Genero genero in generos)
            {
                boxGenero.Items.Add(genero.Nome);
            }
        }

            private void btnCadastrasFilme_Click(object sender, EventArgs e)
            {
            // Crie um novo objeto Filme
            Filme filme = new Filme();
            filme.Nome = textNomeFilme.Text;
            TimeSpan duracao = TimeSpan.Parse(textDuracao.Text);
            string duracaoFormatada = duracao.ToString(@"hh\:mm");
            filme.Duracao = TimeSpan.Parse(duracaoFormatada);
            filme.Sinopse = textSinopse.Text;

            if (boxCategoria.SelectedValue != null)
            {
                idCategoria = Convert.ToInt32(boxCategoria.SelectedValue);
                // Faça algo com o valor selecionado
            }

            if (boxCategoria.SelectedValue != null)
            {
                idCategoria = Convert.ToInt32(boxCategoria.SelectedValue);
                filme.IdCategoria = idCategoria;
            }

            if (boxGenero.SelectedValue != null)
            {
                int idGenero = Convert.ToInt32(boxGenero.SelectedValue);
                filme.IdGenero = idGenero;
            }


            filme.IdCategoria = 10;
            filme.IdGenero = 13;


            filmeDAL.InserirFilme(filme);

            textNomeFilme.Text = "";
            textDuracao.Text = "";
            textSinopse.Text = "";
            boxGenero.SelectedIndex = -1;
            boxCategoria.SelectedIndex = -1;
            boxLocado.Checked = false;

            MessageBox.Show("Dados inseridos com sucesso!");

            CarregarGrid();


        }
        private void Form_Load(object sender, EventArgs e)
        {
            // Atualiza o DataGridView com os dados dos filmes
            CarregarGrid();
        }

        private void AtualizarGrid()
        {
            // Obtém a lista de filmes
            List<Filme> filmes = filmeDAL.ObterFilmes();

            // Vincula a lista de filmes ao DataSource do DataGridView
            textFilme.DataSource = filmes;
        }
        private void textFilme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textFilme.DataSource = filmeDAL.ObterFilmes().ToList();
            CarregarGrid();

        }

        private void FrmTelaFilme_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
        public void CarregarGrid()
        {
            List<Filme> filmes = filmeDAL.ObterFilmes();

            textFilme.AutoGenerateColumns = false;
            textFilme.Columns.Clear();

            textFilme.Columns.Add("Id", "ID");
            textFilme.Columns["Id"].DataPropertyName = "Id";

            textFilme.Columns.Add("Nome", "Nome");
            textFilme.Columns["Nome"].DataPropertyName = "Nome";

            textFilme.Columns.Add("Duracao", "Duração");
            textFilme.Columns["Duracao"].DataPropertyName = "Duracao";

            textFilme.Columns.Add("Sinopse", "Sinopse");
            textFilme.Columns["Sinopse"].DataPropertyName = "Sinopse";

            textFilme.Columns.Add("StLocado", "Locado");
            textFilme.Columns["StLocado"].DataPropertyName = "StLocado";

            textFilme.Columns.Add("Banner", "Banner");
            textFilme.Columns["Banner"].DataPropertyName = "Banner";

            textFilme.Columns.Add("IdCategoria", "ID Categoria");
            textFilme.Columns["IdCategoria"].DataPropertyName = "IdCategoria";

            textFilme.Columns.Add("IdGenero", "ID Gênero");
            textFilme.Columns["IdGenero"].DataPropertyName = "IdGenero";

            textFilme.DataSource = filmes;
        }
    }
}
