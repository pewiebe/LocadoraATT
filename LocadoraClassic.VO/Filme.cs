using System;


namespace LocadoraClassic.VO
{
    public class Filme
    {
        public string Nome { get; set; }
        public TimeSpan Duracao { get; set; }
        public string Sinopse { get; set; }
        public bool StLocado { get; set; }
        public string Banner { get; set; }
        public int IdCategoria { get; set; }
        public int IdGenero { get; set; }

        public Filme()
        {
        }

        public Filme(string nome, TimeSpan duracao, string sinopse, bool stLocado, string banner, int idCategoria, int idGenero)
        {
            Nome = nome;
            Duracao = duracao;
            Sinopse = sinopse;
            StLocado = stLocado;
            Banner = banner;
            IdCategoria = idCategoria;
            IdGenero = idGenero;
        }
    }
}
    