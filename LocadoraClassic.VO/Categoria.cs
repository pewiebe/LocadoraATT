using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClassic.VO
{

    public class Categoria
    {

        public int Id { get; set; }

        public string ValordaDiaria { get; set; }


        public string Nome { get; set; }

        public Categoria()

        {


        }

        public Categoria(int id, string nome)
        {
            Id = id;
            Nome = nome;


        }
        public Categoria(string valordadiaria)
        {
            ValordaDiaria = valordadiaria;
        }
        public override string ToString()
        {
            return Nome;
        }

    }

}