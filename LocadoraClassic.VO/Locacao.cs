using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.VO
{
    public class Locacao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Categoria Categoria { get; set; }
        public Genero Genero { get; set; }
        public Locacao()
        {

        }      
        public Locacao(int id, string nome, Categoria categoria, Genero genero)
        {
            Id = id;
            Nome = nome;
            Categoria = categoria;
            Genero = genero;
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}
