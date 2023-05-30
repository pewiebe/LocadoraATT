﻿using LocadoraClassic.VO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace LocadoraClassic.DAL
{
    public class FilmeDAL
    {
        public List<Filme> ObterFilmes()
        {
            // Abrir a Conexão
            Conexao.Instance.Open();

            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM filme";

            // Executar o comando e obter o resultado
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

            // Fechar a conexão e retornar os filmes obtidos
            reader.Close();
            Conexao.Instance.Close();
            return filmes;
        }

        public void InserirFilme(Filme filme)
        {

            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO filme(nome, duracao, sinopse, stlocado, banner, idcategoria, idgenero) " +
                                  "VALUES (@nome, @duracao, @sinopse, @stlocado, @banner, @idcategoria, @idgenero)";

            // Adicionar parâmetros
            comando.Parameters.Add(new MySqlParameter("@nome", filme.Nome));
            comando.Parameters.Add(new MySqlParameter("@duracao", filme.Duracao.ToString()));
            comando.Parameters.Add(new MySqlParameter("@sinopse", filme.Sinopse ?? (object)DBNull.Value));
            comando.Parameters.Add(new MySqlParameter("@stlocado", filme.StLocado));
            comando.Parameters.Add(new MySqlParameter("@banner", filme.Banner ?? (object)DBNull.Value));

            // Verificar se os valores das chaves estrangeiras existem nas tabelas referenciadas
            int idCategoriaExistente = VerificarExistenciaCategoria(filme.IdCategoria);
            int idGeneroExistente = VerificarExistenciaGenero(filme.IdGenero);
            if (idCategoriaExistente != -1 && idGeneroExistente != -1)
            {
                comando.Parameters.Add(new MySqlParameter("@idcategoria", idCategoriaExistente));
                comando.Parameters.Add(new MySqlParameter("@idgenero", idGeneroExistente));

                comando.ExecuteNonQuery();
                Conexao.Instance.Close();
            }
        }

        private int VerificarExistenciaCategoria(int idCategoria)
        {
            // Abrir a Conexão
            Conexao.Instance.Open();

            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT COUNT(*) FROM categoria WHERE id = @idCategoria";
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);

            // Executar o comando e obter o resultado
            int count = Convert.ToInt32(comando.ExecuteScalar());

            // Fechar a conexão
            Conexao.Instance.Close();

            // Verificar se o valor de idCategoria existe na tabela categoria
            // Retornar o idCategoria existente se encontrado, caso contrário, retornar -1
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
            // Abrir a Conexão
            Conexao.Instance.Open();

            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT COUNT(*) FROM genero WHERE id = @idGenero";
            comando.Parameters.AddWithValue("@idGenero", idGenero);

            // Executar o comando e obter o resultado
            int count = Convert.ToInt32(comando.ExecuteScalar());

            // Fechar a conexão
            Conexao.Instance.Close();

            // Verificar se o valor de idGenero existe na tabela genero
            // Retornar o idGenero existente se encontrado, caso contrário, retornar -1
            if (count > 0)
            {
                return idGenero;
            }
            else
            {
                return -1;
            }
        }
    }
}
 