using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.VO
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }

        public Cliente()
        {

        }

        // Construtor com ID e Nome
        public Cliente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        // Construtor com Nome, Endereço, Número, RG e CPF
        public Cliente(string nome, string endereco, string numero, string rg, string cpf)
        {
            Nome = nome;
            Endereco = endereco;
            Numero = numero;
            RG = rg;
            CPF = cpf;
        }
    }
}
