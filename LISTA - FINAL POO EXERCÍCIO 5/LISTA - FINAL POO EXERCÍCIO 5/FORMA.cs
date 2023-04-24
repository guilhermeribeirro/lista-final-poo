using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_5_lista_poo
{
    abstract class Forma
    {
        public double area { get; set; }
        public double perimetro { get; set; }

        public string cor { get; set; }




        public virtual double CalcularPerimetro() {return 0; }
        public virtual double CalcularArea() { return 0; }

        public virtual double calcularCor() { return 0; }
    }
}