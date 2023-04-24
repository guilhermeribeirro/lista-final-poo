using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA___FINAL_POO_EXERCICIO_7
{
    internal class Horista : Empregado

    {
        public double PrecodaHora { get; set; }

        public double TotaisdeHoras { get; set; }

        public override double Vencimento()
        {

            return PrecodaHora * TotaisdeHoras;
        }
    }
}
