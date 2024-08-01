using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroBinario
{
    public class Program
    {
        static string ConvertirBinario(int numero)
        {
            string numeroBinario = "";
            for (int i = numero; i > 0; i /= 2)
            {
                int remainder = i % 2;
                numeroBinario = remainder + numeroBinario;
            }

            return numeroBinario;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"El número binario del numero '{numero}' es: {ConvertirBinario(numero)}");


            Console.ReadKey();
        }
    }
}
