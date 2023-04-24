using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_5_lista_poo
{


    class Circunferencia : Forma
    {
        public double raio;

        public Circunferencia(double raio)
        {
            this.raio = raio;
        }

        public override double CalcularArea()
        {
            return Math.PI * raio * raio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * raio;
        }
    }
}