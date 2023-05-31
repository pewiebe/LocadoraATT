using LocadoraClassic.VO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace LocadoraClassic.DAL
{
    public class FilmeDAL
    {
        public List<Filme> ObterFilmes()
        {
            if (Conexao.Instance == null)
            {
                Conexao.Instance.Open();
            }

            MySqlCommand comando = Conexao.Instance.CreateCommand();
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
                        filmes.Add(filme);
                    }

                    return filmes;
                
            
        }

        public void InserirFilme(Filme filme)
        {
            if(Conexao.Instance == null)
            {
                Conexao.Instance.Open();
            }  
               

            MySqlCommand comando = Conexao.Instance.CreateCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO filme(nome, duracao, sinopse, stlocado, banner, idcategoria, idgenero) " +
                                      "VALUES (@nome, @duracao, @sinopse, @stlocado, @banner, @idcategoria, @idgenero)";

                comando.Parameters.AddWithValue("@nome", filme.Nome);
                comando.Parameters.AddWithValue("@duracao", filme.Duracao.ToString("hh\\:mm\\:ss"));
                comando.Parameters.AddWithValue("@sinopse", filme.Sinopse ?? (object)DBNull.Value);
                comando.Parameters.AddWithValue("@stlocado", filme.StLocado);
                comando.Parameters.AddWithValue("@banner", filme.Banner ?? (object)DBNull.Value);
                comando.Parameters.AddWithValue("@idcategoria", filme.IdCategoria);
                comando.Parameters.AddWithValue("@idgenero", filme.IdGenero);
                // Verificar a existência da categoria e do gênero antes de inserir o filme
                int idCategoria = VerificarExistenciaCategoria(filme.IdCategoria);
                int idGenero = VerificarExistenciaGenero(filme.IdGenero);

                if (idCategoria != -1 && idGenero != -1)
                {
                    comando.ExecuteNonQuery();
                }
                else
                {
                    Console.WriteLine("Categoria ou gênero inválido.");
                }
            
        }

        private int VerificarExistenciaCategoria(int idCategoria)
        {


                Conexao.Instance.Open();       

                MySqlCommand comando = Conexao.Instance.CreateCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT COUNT(*) FROM categoria WHERE id = @idCategoria";
                comando.Parameters.AddWithValue("@idCategoria", idCategoria);

                int count = Convert.ToInt32(comando.ExecuteScalar());

                if (count > 0)
                {
                    return idCategoria;
                }
                else
                {
                    return -1;
                }
            
        }

        private int VerificarExistenciaGenero(int idGenero)
        {
           
                if (Conexao.Instance == null)
                {
                    Conexao.Instance.Open();
                }

                MySqlCommand comando = Conexao.Instance.CreateCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT COUNT(*) FROM genero WHERE id = @idGenero";
                comando.Parameters.AddWithValue("@idGenero", idGenero);

                int count = Convert.ToInt32(comando.ExecuteScalar());

                if (count > 0)
                {
                    return idGenero;
                }
                else
                {
                    return -1;
                }
            }

        public List<Filme> ObterFilmeTeste()
        {
            // Abrir a Conexão
            Conexao.Instance.Open();

            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM cliente";

            // Executar o comando e obter o resultado
            MySqlDataReader reader = comando.ExecuteReader();
            List<Filme> clientes = new List<Filme>();

            while (reader.Read())
            {
                Filme filme = new Filme();
                filme.Id = Convert.ToInt32(reader["id"]);
                filme.Nome = reader["nome"].ToString();
                filme.Duracao = TimeSpan.Parse(reader["duracao"].ToString());
                filme.Sinopse = reader["sinopse"].ToString();
                filme.StLocado = Convert.ToBoolean(reader["stlocado"]);
                filme.Banner = reader["banner"].ToString();
                filme.Add(filme);
            }

            // Fechar o reader
            reader.Close();

            // Fechar a conexão
            Conexao.Instance.Close();

            return filme;
        }

    }
}