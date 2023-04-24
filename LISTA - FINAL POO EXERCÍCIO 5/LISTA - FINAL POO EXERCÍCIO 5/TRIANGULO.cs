using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_5_lista_poo
{
    class Triangulo : Forma
    {
        public Triangulo(double ladoAbase, double ladoBaltura)
        {
            this.ladoAbase = ladoAbase;
            this.ladoBaltura = ladoBaltura;
        }

        public double ladoAbase { get; set; }
        public double ladoBaltura { get; set; }

        public override double CalcularArea()
        {
            return (ladoAbase * ladoBaltura) / 2;
        }

        public override double CalcularPerimetro()
        {
            Console.WriteLine("nao existe ");
            return 0 ;
        }

    }
}