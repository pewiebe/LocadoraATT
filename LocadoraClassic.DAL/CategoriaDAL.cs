using LocadoraClassic.VO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace LocadoraClassic.DAL
{

    public class CategoriaDAL
    {
        public void InserirCategoria(Categoria categoria)
        {
            // Abrir a Conexão
            Conexao.Instance.Open();

            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO categoria(nome,valordadiaria) VALUES (@nome,@valordadiaria)";

            // Adicionar parâmetros
            comando.Parameters.Add(new MySqlParameter("@nome", categoria.Nome));
            comando.Parameters.Add(new MySqlParameter("@valordadiaria", categoria.ValordaDiaria.ToString()));

            comando.ExecuteNonQuery();
            Conexao.Instance.Close();
        }

        public List<Categoria> ObterCategorias()
        {
            // Abrir a Conexão
            Conexao.Instance.Open();

            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM categoria";

            // Executar o comando e obter o resultado
            MySqlDataReader reader = comando.ExecuteReader();

            List<Categoria> categorias = new List<Categoria>();

            while (reader.Read())
            {
                Categoria categoria = new Categoria();
                categoria.Id = Convert.ToInt32(reader["id"]);
                categoria.Nome = reader["nome"].ToString();
                categoria.ValordaDiaria = reader["valordadiaria"].ToString();
                categorias.Add(categoria);
            }

            // Fechar a conexão e retornar as categorias obtidas
            reader.Close();
            Conexao.Instance.Close();

            return categorias;

        }
        public void ExcluirCategoria(int id)
        {
            // Abrir a Conexão
            Conexao.Instance.Open();

            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM categoria WHERE id = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            // Fechar a conexão
            Conexao.Instance.Close();
        }
        public void AtualizarGenero(Genero genero)
        {
            // Abrir a Conexão
            Conexao.Instance.Open();

            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "UPDATE genero SET nome = @nome WHERE id = @id";
            comando.Parameters.AddWithValue("@nome", genero.Nome);
            comando.Parameters.AddWithValue("@id", genero.Id);
            comando.ExecuteNonQuery();

            // Fechar a conexão
            Conexao.Instance.Close();
        }
    }
}