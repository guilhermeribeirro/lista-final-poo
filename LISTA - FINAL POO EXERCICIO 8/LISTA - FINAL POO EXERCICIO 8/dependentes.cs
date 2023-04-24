using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA___FINAL_POO_EXERCICIO_8
{
    internal class Dependentes
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Dependentes(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
