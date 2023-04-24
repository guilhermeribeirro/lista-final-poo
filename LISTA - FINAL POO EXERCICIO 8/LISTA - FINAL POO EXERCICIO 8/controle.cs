using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA___FINAL_POO_EXERCICIO_8
{
    internal class Controle
    {
        public List<Funcionarios> Funcionarios { get; set; }

        public Controle()
        {
            Funcionarios = new List<Funcionarios>();
        }

        public void AdicionarFuncionario(string nome, int idade)
        {
            Funcionarios funcionario = new Funcionarios(nome, idade);
            Funcionarios.Add(funcionario);
        }

        public void ExibirDependentesFuncionario(string nome)
        {
            Funcionarios funcionarioEncontrado = Funcionarios.Find(f =>
            {
                string nome1 = f.Nome;
                return nome1 == nome;
            });
            if (funcionarioEncontrado != null)
            {
                funcionarioEncontrado.ExibirDependentes();
            }
            else
            {
                Console.WriteLine($"Funcionário {nome} não encontrado.");
            }
        }
    }
}
