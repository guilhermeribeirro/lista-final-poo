using exercicio_5_lista_poo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA___FINAL_POO_EXERCÍCIO_5
{
    class Hexagono : Forma
    {
        public double Lado { get; set; }

        public Hexagono(double lado)
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return 3 * Math.Sqrt(3) * Math.Pow(Lado, 2) / 2;
        }

        public override double CalcularPerimetro()
        {
            return 6 * Lado;
        }
    }

}
