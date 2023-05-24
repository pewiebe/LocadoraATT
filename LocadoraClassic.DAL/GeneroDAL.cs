using LocadoraClassic.VO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace LocadoraClassic.DAL
{

    public class GeneroDAL
    {
        public void InserirGenero(Genero genero)
        {
            //Abrir a Conexão
            Conexao.Instance.Open();

            //MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            //DML - INSERT - DELETE - UPDATE - SELECT
            //STORED PROCEDURES
            //ADO.NET - biblioteca de banco de dados do .NET

            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO genero(nome)values(@nome)";
            comando.Parameters.Add(new MySqlParameter("@nome", genero.Nome));
            comando.ExecuteNonQuery();
            Conexao.Instance.Close();
        }

        public List<Genero> ObterGeneros()
        {
            //Abrir a Conexão
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
    }
}






