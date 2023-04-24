using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_FINAL_POO_EXERCICIO_9
{
    class Autor
    {
        public string Nome { get; set; }
        public string PaisOrigem { get; set; }
        public DateTime DataNascimento { get; set; }
        public string IdiomaNativo { get; set; }


        public Autor(string nome, string paisOrigem, DateTime dataNascimento, string idiomaNativo)
        {
            Nome = nome;
            PaisOrigem = paisOrigem;
            DataNascimento = dataNascimento;
            IdiomaNativo = idiomaNativo;
        }

        public Autor(string? nomeAutor)
        {
        }
    }
}
