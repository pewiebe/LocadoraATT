using LocadoraClassic.VO;
using MySql.Data.MySqlClient;

namespace LocadoraClassic.DAL
{
    public class FilmeDAL
    {
        public void InserirFilme(Filme filme)
        {
            // Abrir a Conexão
            Conexao.Instance.Open();

            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO filme(nome, duracao, sinopse, stlocado, banner, idcategoria, idgenero) " +
                                  "VALUES (@nome, @duracao, @sinopse, @stlocado, @banner, @idcategoria, @idgenero)";

            // Converter TimeSpan para o formato adequado (horas:minutos)
            string duracaoFormatada = filme.Duracao.ToString(@"hh\:mm");

            // Adicionar parâmetros
            comando.Parameters.Add(new MySqlParameter("@nome", filme.Nome));
            comando.Parameters.Add(new MySqlParameter("@duracao", duracaoFormatada));
            comando.Parameters.Add(new MySqlParameter("@sinopse", filme.Sinopse));
            comando.Parameters.Add(new MySqlParameter("@stlocado", filme.StLocado));
            comando.Parameters.Add(new MySqlParameter("@banner", filme.Banner));
            comando.Parameters.Add(new MySqlParameter("@idcategoria", filme.IdCategoria));
            comando.Parameters.Add(new MySqlParameter("@idgenero", filme.IdGenero));

            comando.ExecuteNonQuery();
            Conexao.Instance.Close();
        }
    }
}
