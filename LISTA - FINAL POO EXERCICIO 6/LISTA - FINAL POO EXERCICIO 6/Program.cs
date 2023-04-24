using System;

namespace LISTA___FINAL_POO_EXERCICIO_6
{

    class program
    {

        static void Main (string[]args )
        {
            int quantidade = 0;
            Console.WriteLine("Digite o texto a ser impresso: ");

            string texto = Console.ReadLine();


            DOCUMENTO documento = new DOCUMENTO(texto);

            IMPRESSORA impressora = new IMPRESSORA(documento);

            Console.WriteLine("Digite a quantidade de copias a seem impressas: ");

            quantidade = Convert.ToInt32(Console.ReadLine());

            impressora.Imprimir(quantidade);

            Console.WriteLine("Pressione qualquer tecla para sair do programa!");













        }























    }





















}