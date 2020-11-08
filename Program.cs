using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXPRESIONES_LAMBDA
{
    // Expresión lambda es una función anónima (o método anónimo) cuya ejecución depende del contexto en el cual se encuentre

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            numeros.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            // Uso de la expresión lambda
            // 1. declaro tipo de parametro i implicitamente (o explicitamente, indicando que i es int
            //List<int> numPares = numeros.FindAll(i => (i % 2) == 0); // Función lambda funciona similar a una función anónima

            // Misma expresión lambda, más compleja
            List<int> numPares = numeros.FindAll(i =>
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine("Número par");
                    return true; // FindAll obtiene true o false, por ello se retorna true
                }
                else
                {
                    Console.WriteLine("Número impar");
                    return false;
                }
            });

            // Mostrar los numeros
            foreach (var n in numPares)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}
