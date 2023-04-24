using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_FINAL_POO_EXERCICIO_9
{
    class Livro
    {
        private string? dataLancamento;

        public string ISBN { get; set; }
        public string NomeLivro { get; set; }
        public Autor Autor { get; set; }
        public string Idioma { get; set; }
        public string Edicao { get; set; }
        public DateTime DataLancamento { get; set; }

        public Livro(string isbn, string nomeLivro, Autor autor, string idioma, string edicao, DateTime dataLancamento)
        {
            ISBN = isbn;
            NomeLivro = nomeLivro;
            Autor = autor;
            Idioma = idioma;
            Edicao = edicao;
            DataLancamento = dataLancamento;
        }

        public Livro(string? isbn, string? nomeLivro, Autor autor, string? idioma, string? edicao, string? dataLancamento)
        {
            ISBN = isbn;
            NomeLivro = nomeLivro;
            Autor = autor;
            Idioma = idioma;
            Edicao = edicao;
            this.dataLancamento = dataLancamento;
        }
    }
}
