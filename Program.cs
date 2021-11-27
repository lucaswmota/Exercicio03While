using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03While
{
    class Program
    {
        static void Main(string[] args)
        {

            int cont = 0;

            while (cont <= 100)
            {

                Console.WriteLine("Contagem de numeros pares: " + cont);

                cont += 2;
            }

            Console.ReadKey();

        }

        

        
    }
}
