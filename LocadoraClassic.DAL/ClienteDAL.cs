using LocadoraClassic.VO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace LocadoraClassic.DAL
{
    public class ClienteDAL
    {
        public void InserirCliente(Cliente cliente)
        {
            //Abrir a Conexão
            Conexao.Instance.Open();

            //MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "INSERT INTO cliente(nome, endereco, numero, rg, cpf) VALUES (@nome, @endereco, @numero, @rg, @cpf)";
            comando.Parameters.Add(new MySqlParameter("@nome", cliente.Nome));
            comando.Parameters.Add(new MySqlParameter("@endereco", cliente.Endereco));
            comando.Parameters.Add(new MySqlParameter("@numero", cliente.Numero));
            comando.Parameters.Add(new MySqlParameter("@rg", cliente.RG));
            comando.Parameters.Add(new MySqlParameter("@cpf", cliente.CPF));
            comando.ExecuteNonQuery();
            Conexao.Instance.Close();
        }

        public List<Cliente> ObterClientes()
        {
            //Abrir a Conexão
            Conexao.Instance.Open();
            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "SELECT * FROM cliente";
            // Executar o comando e obter o resultado
            MySqlDataReader reader = comando.ExecuteReader();
            List<Cliente> clientes = new List<Cliente>();
            while (reader.Read())
            {
                Cliente cliente = new Cliente();
                cliente.Id = Convert.ToInt32(reader["id"]);
                cliente.Nome = reader["nome"].ToString();
                cliente.Endereco = reader["endereco"].ToString();
                cliente.Numero = reader["numero"].ToString();
                cliente.RG = reader["rg"].ToString();
                cliente.CPF = reader["cpf"].ToString();
                clientes.Add(cliente);
            }
            // Fechar a conexão e retornar os clientes obtidos
            reader.Close();
            Conexao.Instance.Close();
            return clientes;
        }
        public void ExcluirCliente(int id)
        {
            // Abrir a Conexão
            Conexao.Instance.Open();

            // MySqlCommand
            MySqlCommand comando = Conexao.Instance.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "DELETE FROM cliente WHERE id = @id";
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();

            // Fechar a conexão
            Conexao.Instance.Close();
        }
    }
}