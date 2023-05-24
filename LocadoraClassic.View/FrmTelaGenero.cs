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
        public FrmTelaGenero()
        {
            InitializeComponent();
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
            MessageBox.Show("Dados inseridos com sucesso!");


        }

        private void textGenero_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void FrmTelaGenero_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        public void CarregarGrid()
        {
            textGenero.DataSource = GeneroDAL.ObterGeneros().ToList();
        }
    }
}
