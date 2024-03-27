using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int[,] numeros = new int[2, 2];
            int Par = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {

                    while (true)
                    {
                        Console.WriteLine($"Informe numero para as posicoes [{i}],[{j}] da matriz");

                        try
                        {
                            numeros[i, j] = int.Parse(Console.ReadLine());

                            if (numeros[i, j] % 2 == 0)
                            {
                                Par++;
                            }
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Informe um número INTEIRO");
                        }
                    }
                }
            }

            foreach (int elemento in numeros)
            {
                Console.WriteLine();
                Console.WriteLine(elemento + " ");

            }

            Console.WriteLine($"\n\nA matriz contém {Par} número(s) par(es)");


            Console.ReadLine();
        }
    }
}


