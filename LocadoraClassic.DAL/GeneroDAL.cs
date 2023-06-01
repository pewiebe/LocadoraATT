using LocadoraClassic.VO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace LocadoraClassic.DAL
{
    public class GeneroDAL
    {
        public void InserirGenero(Genero genero)
        {
            // Abrir a Conexão
            Conexao.Instance.Open();

            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO genero(nome) VALUES (@nome)";
            comando.Parameters.Add(new MySqlParameter("@nome", genero.Nome));
            comando.ExecuteNonQuery();
            // Fechar a conexão
            Conexao.Instance.Close();
        }
        public void ExcluirGenero(int id)
        {
            // Abrir a Conexão
            Conexao.Instance.Open();

            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM genero WHERE id = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            // Fechar a conexão
            Conexao.Instance.Close();
        }

        public List<Genero> ObterGeneros()
        {
            // Abrir a Conexão
            Conexao.Instance.Open();
            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM genero";
            // Executar o comando e obter o resultado
            MySqlDataReader reader = comando.ExecuteReader();
            List<Genero> generos = new List<Genero>();
            while (reader.Read())
            {
                Genero genero = new Genero();
                genero.Id = Convert.ToInt32(reader["id"]);
                genero.Nome = reader["nome"].ToString();
                generos.Add(genero);
            }
            // Fechar a conexão e retornar os gêneros obtidos
            reader.Close();
            Conexao.Instance.Close();
            return generos;
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
