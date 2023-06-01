using LocadoraClassic.DAL;
using LocadoraClassic.VO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LocadoraClassic.View
{
    public partial class FrmTelaFilme : Form
    {
        FilmeDAL filmeDAL = new FilmeDAL();
        CategoriaDAL categoriaDAL = new CategoriaDAL();
        GeneroDAL generoDAL = new GeneroDAL();
        int idSelecionadoCat;
        int idSelecionadoGen;

        public FrmTelaFilme()
        {
            InitializeComponent();
            PreencherComboBoxCategorias();
            PreencherComboBoxGeneros();
            CarregarGrid();
        }

        private void PreencherComboBoxCategorias()
        {
            boxCategoria.DisplayMember = "Nome";
            boxCategoria.ValueMember = "Id";
            boxCategoria.DataSource = categoriaDAL.ObterCategorias().ToList();
        }
        // Crie um método para preencher o ComboBox com as categorias
        private void PreencherComboBoxGeneros()
        {

            boxGenero.DisplayMember = "Nome";
            boxGenero.ValueMember = "Id";
            boxGenero.DataSource = generoDAL.ObterGeneros().ToList();

        }

        private void btnCadastrasFilme_Click(object sender, EventArgs e)
        {
           idSelecionadoCat = (int)boxCategoria.SelectedValue;
           idSelecionadoGen = (int)boxGenero.SelectedValue;

       
            string duracaoInput = textDuracao.Text;

            // Verifica se o valor inserido está no formato correto HH:mm usando uma expressão regular
            if (Regex.IsMatch(duracaoInput, @"^\d{1,2}:\d{2}$"))
            {
                TimeSpan duracao;
                if (TimeSpan.TryParseExact(duracaoInput, @"hh\:mm", CultureInfo.InvariantCulture, out duracao))
                {
                    int duracaoMinutos = (int)duracao.TotalMinutes;

                    // Criação do objeto Filme com os valores
                    Filme filme = new Filme()
                    {
                        Nome = textNomeFilme.Text,
                        Duracao = TimeSpan.FromMinutes(duracaoMinutos),
                        Sinopse = textSinopse.Text,
                        IdCategoria = idSelecionadoCat,
                        IdGenero = idSelecionadoGen,
                    };



                    filmeDAL.InserirFilme(filme);

                    textNomeFilme.Text = "";
                    textDuracao.Text = "";
                    textSinopse.Text = "";
                    boxGenero.SelectedIndex = -1;
                    boxCategoria.SelectedIndex = -1;
                    boxLocado.Checked = false;

                    CarregarGrid();
                }
                else
                {
                    MessageBox.Show("A duração inserida é inválida.");
                }
            }
            else
            {
                MessageBox.Show("O formato da duração está incorreto. Use o formato HH:mm.");
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            PreencherComboBoxCategorias();
            PreencherComboBoxGeneros();
        }

        private void AtualizarGrid()
        {
            // Obtém a lista de filmes
            List<Filme> filmes = filmeDAL.ObterFilmes();

            textFilmes.DataSource = filmes;
        }
        private void textFilme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textFilmes.DataSource = filmeDAL.ObterFilmes().ToList();
            CarregarGrid();

        }

        private void FrmTelaFilme_Load(object sender, EventArgs e)
        {

            AtualizarGrid();

        }
        public void CarregarGrid()
        {
            List<Filme> filmes = filmeDAL.ObterFilmes();

            textFilmes.AutoGenerateColumns = false;
            textFilmes.Columns.Clear();

            textFilmes.Columns.Add("Id", "ID");
            textFilmes.Columns["Id"].DataPropertyName = "Id";

            textFilmes.Columns.Add("Nome", "Nome");
            textFilmes.Columns["Nome"].DataPropertyName = "Nome";

            textFilmes.Columns.Add("Duracao", "Duração");
            textFilmes.Columns["Duracao"].DataPropertyName = "Duracao";

            textFilmes.Columns.Add("Sinopse", "Sinopse");
            textFilmes.Columns["Sinopse"].DataPropertyName = "Sinopse";

            textFilmes.Columns.Add("StLocado", "Locado");
            textFilmes.Columns["StLocado"].DataPropertyName = "StLocado";

            textFilmes.Columns.Add("Banner", "Banner");
            textFilmes.Columns["Banner"].DataPropertyName = "Banner";

            textFilmes.Columns.Add("IdCategoria", "ID Categoria");
            textFilmes.Columns["IdCategoria"].DataPropertyName = "IdCategoria";

            textFilmes.Columns.Add("IdGenero", "ID Gênero");
            textFilmes.Columns["IdGenero"].DataPropertyName = "IdGenero";

            textFilmes.DataSource = filmes;
        }

        private void boxLocado_CheckedChanged(object sender, EventArgs e)
        {
            if (textFilmes.SelectedRows.Count > 0)
            {
                int idFilme = Convert.ToInt32(textFilmes.SelectedRows[0].Cells["Id"].Value);
                bool locado = boxLocado.Checked;
                CarregarGrid();
            }
        }
       private void textDuracao_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            AtualizarGrid();

        }
    }
}
