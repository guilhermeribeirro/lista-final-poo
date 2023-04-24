using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA___FINAL_POO_EXERCICIO_7
{
    internal class Comissionado : Empregado
    {
        public double VendasTotais { get; set; }

        public double Comissao { get; set; }

        public override double Vencimento()
        {
            return VendasTotais * (Comissao / 100);

        }
    

    }
}
