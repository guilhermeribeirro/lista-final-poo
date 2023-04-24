
using LISTA_FINAL_POO_EXERCICIO_9;
using System;

class Program
{
    static Biblioteca biblioteca = new Biblioteca();

    static void Main(string[] args)
    {
        bool sair = false;
        while (!sair)
        {
            Console.Clear();
            Console.WriteLine("==== BIBLIOTECA ====");
            Console.WriteLine("1. Cadastrar Livro");
            Console.WriteLine("2. Remover Livro");
            Console.WriteLine("3. Listar Livros");
            Console.WriteLine("4. Listar Livros em Ordem Alfabética");
            Console.WriteLine("5. Listar Livros por Idioma");
            Console.WriteLine("6. Listar Autores com Livros em Outros Idiomas");
            Console.WriteLine("7. Sair");
            Console.WriteLine("=====================");
            Console.Write("Escolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarLivro();
                    break;
                case "2":
                    RemoverLivro();
                    break;
                case "3":
                    ListarLivros();
                    break;
                case "4":
                    ListarLivrosOrdemAlfabetica();
                    break;
                case "5":
                    ListarLivroPorIdioma();
                    break;
                case "6":
                    ListarAutorLivroOutroIdioma();
                    break;
                case "7":
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }

    static void CadastrarLivro()
    {
        Console.WriteLine("==== CADASTRAR LIVRO ====");
        Console.Write("ISBN: ");
        string isbn = Console.ReadLine();
        Console.Write("Nome do Livro: ");
        string nomeLivro = Console.ReadLine();
        Console.Write("Autor: ");
        string nomeAutor = Console.ReadLine();
        Console.Write("Idioma: ");
        string idioma = Console.ReadLine();
        Console.Write("Edição: ");
        string edicao = Console.ReadLine();
        Console.Write("Data de Lançamento: ");
        string dataLancamento = Console.ReadLine();

        Autor autor = new Autor (nomeAutor);
        Livro livro = new Livro(isbn, nomeLivro, autor, idioma, edicao, dataLancamento);
        biblioteca.AcrescentarLivros(livro);

        Console.WriteLine("Livro cadastrado com sucesso!");
    }

    static void RemoverLivro()
    {
        Console.WriteLine("==== REMOVER LIVRO ====");
        Console.Write("Digite o ISBN do livro a ser removido: ");
        string isbn = Console.ReadLine();

        biblioteca.RetirarLivrodoSistema(isbn);

        Console.WriteLine("Livro removido com sucesso!");
    }

    static void ListarLivros()
    {
        Console.WriteLine("==== LISTAR LIVROS ====");
        biblioteca.MostrarLivros();
    }

    static void ListarLivrosOrdemAlfabetica()
    {
        Console.WriteLine("==== LISTAR LIVROS EM ORDEM ALFABÉTICA ====");
        biblioteca.ListaremOrdemAlfabetica();
    }

    static void ListarLivroPorIdioma()
    {
        Console.WriteLine("==== LISTAR LIVROS POR IDIOMA ====");
        Console.Write("Digite o idioma: ");
        string idioma = Console.ReadLine();

        biblioteca.ListarPorIdioma(idioma);
    }
    static void ListarAutorLivroOutroIdioma()
    {
        Console.WriteLine("==== LISTAR AUTORES COM LIVROS EM OUTROS IDIOMAS ====");
        biblioteca.OrdenaremAutorLivroOutroIdioma();
    }
}



