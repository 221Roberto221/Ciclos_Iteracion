using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, exponente, i;
            double resultado=1;

            Console.WriteLine("Dame un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dame el exponente: ");
            exponente = Convert.ToInt32(Console.ReadLine());    
            Console.ReadKey();

            Console.WriteLine("El resultado es: " + resultado);
            Console.ReadKey();

        }
    }
}
