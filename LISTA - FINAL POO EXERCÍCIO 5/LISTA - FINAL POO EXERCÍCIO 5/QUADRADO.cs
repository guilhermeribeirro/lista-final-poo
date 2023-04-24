using System.Text;
using System.Threading.Tasks;

namespace exercicio_5_lista_poo
{
     class quadrado : Forma
    {
       public double lado;

        public quadrado(double lado)
        {
            this.lado = lado;
        }

        public override double CalcularArea()
        {
            return lado * lado;
        }

        public override double CalcularPerimetro()
        {
            return 4 * lado;
        }
    }
}