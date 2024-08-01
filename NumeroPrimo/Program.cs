using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimo
{
    public class Program
    {
        static List<int> NumeroPrimos()
        {
            int numeroDivisores = 0;
            List<int> NumerosPrimos = new List<int>();

            for (int i = 1; i < 101; i++)
            {
                int numero = i;
                for (int j = 1; j <101; j++)
                 {
                    if ((numero % j) == 0)
                    {
                        numeroDivisores++;
                    }
                }
                if (numeroDivisores==2)
                {
                    NumerosPrimos.Add(numero);
                }
                numeroDivisores = 0;
            }

            return NumerosPrimos;
        }
        static void Main(string[] args)
        {
            List<int> NumerosPrimos = NumeroPrimos();

            Console.WriteLine("Los numeros primos del 1 al 100 son los siguientes:");
            foreach (int numero in NumerosPrimos)
            {
                Console.Write(numero + ", ");
            }

            Console.ReadKey();
        }
    }
}
