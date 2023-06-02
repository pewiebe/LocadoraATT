using LocadoraClassic.VO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Data;

namespace LocadoraClassic.DAL
{
    public class FilmeDAL
    {
        public List<Filme> ObterFilmes()
        {
            using (MySqlConnection conexao = new MySqlConnection(Conexao.Instance.ConnectionString))
            {
                conexao.Open();
                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT * FROM filme";
                MySqlDataReader reader = comando.ExecuteReader();

                List<Filme> filmes = new List<Filme>();

                while (reader.Read())
                {
                    Filme filme = new Filme();
                    filme.Id = Convert.ToInt32(reader["id"]);
                    filme.Nome = reader["nome"].ToString();
                    filme.Duracao = TimeSpan.Parse(reader["duracao"].ToString());
                    filme.Sinopse = reader["sinopse"].ToString();
                    filme.StLocado = Convert.ToBoolean(reader["stlocado"]);
                    filme.Banner = reader["banner"].ToString();
                    filme.IdCategoria = Convert.ToInt32(reader["idCategoria"]); 
                    filme.IdGenero = Convert.ToInt32(reader["idGenero"]); 
                    filmes.Add(filme);
                }

                return filmes;

            }
        }

        public void InserirFilme(Filme filme)
        {
           

            Conexao.Instance.Open();
            string query = "INSERT INTO filme (nome, duracao, sinopse, stlocado, banner, idcategoria, idgenero) " +
                               "VALUES (@Nome, @Duracao, @Sinopse, @StLocado, @Banner, @IdCategoria, @IdGenero)";

            MySqlCommand command = Conexao.Instance.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue("@Nome", filme.Nome);
            command.Parameters.AddWithValue("@Duracao", filme.Duracao);
            command.Parameters.AddWithValue("@Sinopse", filme.Sinopse);
            command.Parameters.AddWithValue("@StLocado", filme.StLocado);
            command.Parameters.AddWithValue("@Banner", filme.Banner);
            command.Parameters.AddWithValue("@IdCategoria", filme.IdCategoria);
            command.Parameters.AddWithValue("@IdGenero", filme.IdGenero);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception )
            {
                // Trate a exceção adequadamente ou lance para cima para tratamento em outro lugar
                throw;
            }
        }
        public void ExcluirFilme(int id)
        {
            // Abrir a Conexão
            Conexao.Instance.Open();

            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM filme WHERE id = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            // Fechar a conexão
            Conexao.Instance.Close();
        }
    }
}