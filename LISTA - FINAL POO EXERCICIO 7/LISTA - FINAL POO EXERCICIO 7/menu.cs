using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA___FINAL_POO_EXERCICIO_7
{
   internal class Menu
    {
        static void Main(string[] args)
        {

            while (true)
            {

                MostrarMenu();

                string opcao = Console.ReadLine();

                if (opcao == "0")
                {

                    Console.WriteLine("Saindo do Programa....");
                    break;
                }
                else if (opcao == "1")
                {
                    Assalariado empregado = LerDadosdoAssalariado();
                    ExibiroSalario(empregado);
                }
                else if (opcao == "2")
                {
                    Comissionado empregado = LerDadosdoComissionado();
                    ExibiroSalario(empregado);

                }
                else if (opcao == "3"){

                    Horista empregado = LerDadosdoHorista();

                    ExibiroSalario(empregado);

                }
                else
                {
                    Console.WriteLine("Opção invalida. Tente novamente! ");
                }
            }
        }

       

        static void MostrarMenu()

        {
            Console.WriteLine("Menu: (Digite somente NUMEROS!)");
            Console.WriteLine("Opção 1 - Cadastrar Assalariado ");
            Console.WriteLine("Opção 2 - Cadastrar Comissionario");
            Console.WriteLine("Opção 3 - Cadastrar Horista");
            Console.WriteLine("Opção 0 - Sair do Sistema");
            Console.Write("Por favor digite a opção desejada: ");
        }

        static Assalariado LerDadosdoAssalariado()
        {

            Console.Write("Digite o nome:");

            string nome = Console.ReadLine();

            Console.Write("Digite o sobrenome: ");

            string sobrenome = Console.ReadLine();

            Console.Write("Digite o seu CPF: ");

            string cpf = Console.ReadLine();

            Console.Write("Digite o salario: ");

            double salario = Convert.ToDouble(Console.ReadLine());

            

            return new Assalariado { Nome = nome, Sobrenome = sobrenome, CPF = cpf, Salario = salario };

        }

        static Comissionado LerDadosdoComissionado()
        {

            Console.Write("Digite o Nome; ");
            string nome = Console.ReadLine();


            Console.Write("Digite o Sobrenome: ");

            string sobrenome = Console.ReadLine();

            Console.Write("Digite o seu CPF: ");

            string cpf = Console.ReadLine();


            Console.Write("Digite o total de vendas: ");

            double vendasTotais = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a comissão em PORCENTAGEM %: ");

            double comissao = Convert.ToDouble(Console.ReadLine());

            return new Comissionado { Nome = nome, Sobrenome = sobrenome, CPF = cpf, VendasTotais = vendasTotais, Comissao = comissao };

        }

        static Horista LerDadosdoHorista()
        {

            Console.Write("Digite o nome: ");

            string nome = Console.ReadLine();

            Console.Write("Digite o sobrenome: ");

            string sobrenome = Console.ReadLine();

            Console.Write("Digite o seu CPF: ");

            string cpf = Console.ReadLine();

            Console.Write("Digite o preço da hora: ");

            double precodaHora = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o total de horas trabalhadas: ");

            double totaisdeHoras = Convert.ToDouble(Console.ReadLine());

            return new Horista { Nome = nome, Sobrenome = sobrenome, CPF = cpf, PrecodaHora = precodaHora, TotaisdeHoras = totaisdeHoras };
        }
            static void ExibiroSalario(Empregado empregado)
            {
                Console.WriteLine("Dados do empregado; ");
                Console.WriteLine("Nome: " + empregado.Nome);
                Console.WriteLine("Sobrenome: " + empregado.Sobrenome);
                Console.WriteLine("CPF; " + empregado.CPF);
                Console.WriteLine("Salário: " + empregado.Vencimento());
                Console.WriteLine("---------------------------------");
            }

        
        

    }
}
