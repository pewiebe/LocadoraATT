using LocadoraClassic.VO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.DAL
{
    public class LocacaoDAL
    {
        public string ObterNomeClientePorCPF(string cpf)
        {
            using (MySqlConnection conexao = new MySqlConnection(Conexao.Instance.ConnectionString))
            {
                conexao.Open();
                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT nome FROM cliente WHERE cpf = @cpf";
                comando.Parameters.AddWithValue("@cpf", cpf);
                object result = comando.ExecuteScalar();

                if (result != null)
                {
                    return result.ToString();
                }
                else
                {
                    return string.Empty; // Ou qualquer valor padrão que você deseje retornar se o cliente não for encontrado
                }
            }
        }

        public List<Filme> ObterFilmesPorNome(string nome)
        {
            using (MySqlConnection conexao = new MySqlConnection(Conexao.Instance.ConnectionString))
            {
                conexao.Open();
                MySqlCommand comando = conexao.CreateCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT f.*, c.nome AS categoria, g.nome AS genero " +
                                      "FROM filme f " +
                                      "INNER JOIN categoria c ON f.idcategoria = c.id " +
                                      "INNER JOIN genero g ON f.idgenero = g.id " +
                                      "WHERE f.nome LIKE @nome";
                comando.Parameters.AddWithValue("@nome", "%" + nome + "%");
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
                    filme.IdCategoria = Convert.ToInt32(reader["idcategoria"]);
                    filme.IdGenero = Convert.ToInt32(reader["idgenero"]);
     
                    filmes.Add(filme);
                }

                return filmes;
            }
        }
    }
}
