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
            string binario = "";
            int cuadrado = 8;

            for (int i = 0; i < 4; i++)
            {
                if (numero >= cuadrado)
                {
                    binario += "1";
                    numero -= cuadrado;
                }
                else
                {
                    binario += "0";
                }
                cuadrado = cuadrado / 2;
            }
            return binario;
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
