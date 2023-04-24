using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA___FINAL_POO_EXERCICIO_7
{
    internal class Assalariado : Empregado
    {
        public double Salario { get; set; }

        public override double Vencimento ()
        {
            return Salario;

        }
          


    }
}
