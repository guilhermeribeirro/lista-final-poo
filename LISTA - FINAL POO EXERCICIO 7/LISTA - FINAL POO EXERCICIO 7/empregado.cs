using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA___FINAL_POO_EXERCICIO_7
{
    abstract class Empregado
    {
       
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public abstract double Vencimento();
    }

}
