using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA___FINAL_POO_EXERCICIO_8
{
    internal class Funcionarios
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<Dependentes> Dependentes { get; set; }

        public Funcionarios(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Dependentes = new List<Dependentes>();
        }

        public void AdicionarDependente(string nome, int idade)
        {
            Dependentes dependente = new Dependentes(nome, idade);
            Dependentes.Add(dependente);
        }

        public void ExibirDependentes()
        {
            if (Dependentes.Count >0 )
            {
                Console.WriteLine($"Dependentes de {Nome}:");
                foreach (Dependentes dependente in Dependentes)
                {
                    Console.WriteLine($"Nome: {dependente.Nome}, Idade: {dependente.Idade}");
                }
            }
            else
            {
                Console.WriteLine($"{Nome} não possui dependentes.");
            }
        }
    }
}
