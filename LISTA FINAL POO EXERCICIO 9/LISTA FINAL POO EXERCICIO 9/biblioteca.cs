using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA_FINAL_POO_EXERCICIO_9
{
    class Biblioteca
    {
        private List<Livro> listaDeLivros;

        
        public Biblioteca()
        {
            listaDeLivros = new List<Livro>();
        }

        
        public void AcrescentarLivros(Livro livro)
        {
            listaDeLivros.Add(livro);
        }

       
        public void RetirarLivrodoSistema(string isbn)
        {
            Livro livro = listaDeLivros.Find(l => l.ISBN == isbn);
            if (livro != null)
            {
                listaDeLivros.Remove(livro);
                Console.WriteLine($"Livro com ISBN {isbn} removido da biblioteca.");
            }
            else
            {
                Console.WriteLine($"Livro com ISBN {isbn} não encontrado na biblioteca.");
            }
        }

       

        public void MostrarLivros()
        {
            Console.WriteLine("Lista de Livros na Biblioteca:");
            foreach (Livro livro in listaDeLivros)
            {
                Console.WriteLine($"ISBN: {livro.ISBN}, Nome do Livro: {livro.NomeLivro}, Autor: {livro.Autor.Nome}, Idioma: {livro.Idioma}, Edição: {livro.Edicao}, Data de Lançamento: {livro.DataLancamento}");
            }
        }

       
        public void ListaremOrdemAlfabetica()
        {
            Console.WriteLine("Lista de Livros na Biblioteca em Ordem Alfabética:");
            listaDeLivros.Sort((livro1, livro2) => livro1.NomeLivro.CompareTo(livro2.NomeLivro));
            foreach (Livro livro in listaDeLivros)
            {
                Console.WriteLine($"ISBN: {livro.ISBN}, Nome do Livro: {livro.NomeLivro}, Autor: {livro.Autor.Nome}, Idioma: {livro.Idioma}, Edição: {livro.Edicao}, Data de Lançamento: {livro.DataLancamento}");
            }
        }
        
        public void ListarPorIdioma(string idioma)
        {
            Console.WriteLine($"Lista de Livros na Biblioteca em Idioma {idioma}:");
            List<Livro> livrosPorIdioma = listaDeLivros.FindAll(l => l.Idioma.Equals(idioma, StringComparison.OrdinalIgnoreCase));
            if (livrosPorIdioma.Count > 0)
            {
                foreach (Livro livro in livrosPorIdioma)
                {
                    Console.WriteLine($"ISBN: {livro.ISBN}, Nome do Livro: {livro.NomeLivro}, Autor: {livro.Autor.Nome}, Idioma: {livro.Idioma}, Edição: {livro.Edicao}, Data de Lançamento: {livro.DataLancamento}");
                }
            }
            else
            {
                Console.WriteLine($"Nenhum livro encontrado em idioma {idioma} na biblioteca.");
            }
        }

        
        public void OrdenaremAutorLivroOutroIdioma()
        {
            Console.WriteLine("Lista de Autores com Livros em Outros Idiomas:");
            Dictionary<string, int> autoresLivrosOutroIdioma = new Dictionary<string, int>();
            foreach (Livro livro in listaDeLivros)
            {
                if (!livro.Autor.IdiomaNativo.Equals(livro.Idioma, StringComparison.OrdinalIgnoreCase))
                {
                    if (autoresLivrosOutroIdioma.ContainsKey(livro.Autor.Nome))
                    {
                        autoresLivrosOutroIdioma[livro.Autor.Nome]++;
                    }
                    else
                    {
                        autoresLivrosOutroIdioma[livro.Autor.Nome] = 1;
                    }
                }
            }
            if (autoresLivrosOutroIdioma.Count > 0)
            {
                foreach (var autorLivrosOutroIdioma in autoresLivrosOutroIdioma)
                {
                    Console.WriteLine($"Autor: {autorLivrosOutroIdioma.Key}, Quantidade de Livros em Outros Idiomas: {autorLivrosOutroIdioma.Value}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum autor encontrado com livros em outros idiomas na biblioteca.");
            }
        }
    }
}
