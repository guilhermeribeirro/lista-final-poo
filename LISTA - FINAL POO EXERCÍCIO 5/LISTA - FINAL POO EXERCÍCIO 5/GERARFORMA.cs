using exercicio_5_lista_poo;
using LISTA___FINAL_POO_EXERCÍCIO_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercicio_5_lista_poo
{
    class gerarforma

    {
        public void SolicitarForma()
        {
            Console.WriteLine("Qual o tipo de forma que deseja gerar? (Circunferencia/Triangulo/Quadrado ou Hexagono (DIGITAR EM LETRA MINÚSCULA!)");
            string tipo = Console.ReadLine();
            Forma forma;
            switch (tipo.ToLower())
            {
                case "circunferencia":

                    Console.WriteLine("Digite o raio da circunferência:");
                    double raio = Convert.ToDouble(Console.ReadLine());
                    Circunferencia circunferencia = new Circunferencia(raio);
                    Console.WriteLine($"Área da circunferência: {circunferencia.CalcularArea()}");
                    Console.WriteLine($"Perímetro da circunferência: {circunferencia.CalcularPerimetro()}");
                    break;

                case "triangulo":

                    Console.WriteLine("Digite a base do triângulo:");
                    double ladoAbase = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite a altura do triângulo:");
                    double ladoBaltura = Convert.ToDouble(Console.ReadLine());
                    Triangulo triangulo = new Triangulo(ladoAbase, ladoBaltura);
                    Console.WriteLine($"Área do triângulo: {triangulo.CalcularArea()}");
                    Console.WriteLine($"Perímetro do triângulo: {triangulo.CalcularPerimetro()}");

                    break;

                case "quadrado":
                    Console.WriteLine("Digite o lado do quadrado:");
                    double lado = Convert.ToDouble(Console.ReadLine());
                    quadrado Quadrado = new quadrado(lado);
                    Console.WriteLine($"Área do quadrado: {Quadrado.CalcularArea()}");
                    Console.WriteLine($"Perímetro do quadrado: {Quadrado.CalcularPerimetro()}");
                    break;

                case "hexadono":
                    Console.Write("Digite o lado do hexágono: ");
                    double Lado = Convert.ToDouble(Console.ReadLine());
                    Hexagono hexagono = new Hexagono(Lado);
                    Console.WriteLine($"Área do quadrado: {hexagono.CalcularArea()}");
                    Console.WriteLine($"Perímetro do quadrado: {hexagono.CalcularPerimetro()}");


                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    return;
            }


        }
    }
}