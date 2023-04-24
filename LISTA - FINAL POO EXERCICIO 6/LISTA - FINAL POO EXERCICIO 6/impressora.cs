using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA___FINAL_POO_EXERCICIO_6
{
    internal class IMPRESSORA
    {
        public DOCUMENTO _documento;

        public IMPRESSORA (DOCUMENTO documento)
        {
            _documento = documento;

        }

        public void Imprimir (int quantidade = 1)
        {

            for (int i = 0; i < quantidade; i++)
            {

               
                Console.WriteLine($"imprimindo copia {i + 1} de {quantidade}:");
                Console.WriteLine(_documento.Texto);



            }
        }
    }
}
