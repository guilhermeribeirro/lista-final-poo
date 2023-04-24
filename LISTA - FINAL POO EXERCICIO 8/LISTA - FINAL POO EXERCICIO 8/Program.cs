using LISTA___FINAL_POO_EXERCICIO_8;

class Program
{
    static void Main(string[] args)
    {
        // Exemplo de uso:

        // Criar alguns funcionários e seus dependentes
        Controle controle = new Controle();

        Funcionarios funcionario1 = new Funcionarios("João", 35);
        funcionario1.AdicionarDependente("Maria", 10);
        funcionario1.AdicionarDependente("Pedro", 8);
        controle.AdicionarFuncionario(funcionario1.Nome, funcionario1.Idade);

        Funcionarios funcionario2 = new Funcionarios("Ana", 40);
        funcionario2.AdicionarDependente("Lucas", 15);
        funcionario2.AdicionarDependente("Sophia", 12);
        controle.AdicionarFuncionario(funcionario2.Nome, funcionario2.Idade);

        
        controle.ExibirDependentesFuncionario("Ana");

        controle.ExibirDependentesFuncionario("João");
    }
}

