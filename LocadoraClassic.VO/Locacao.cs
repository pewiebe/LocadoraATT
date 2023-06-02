using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.VO
{
    public class Locacao
    {
        public int id { get; set; }
        public string nome { get; set; }
        public DateTime DataLocacao{ get; set; } 
        public DateTime DataDevolucao { get; set; }
        public int Idcliente { get; set; }
        public int Idfilme { get; set; }

        public Locacao() 
        { 

        }
        public Locacao(int id, string nome, DateTime dataLocacao, DateTime dataDevolucao, int idcliente, int idfilme)
        {
            this.id = id;
            this.nome = nome;
            DataLocacao = dataLocacao;
            DataDevolucao = dataDevolucao;
            Idcliente = idcliente;
            Idfilme = idfilme;
        }
    }
}
