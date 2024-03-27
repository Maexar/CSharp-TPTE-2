using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantos países você deseja inserir?");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            string[] paises = new string[quantidade];

            for (int i = 0; i < paises.Length; i++)
            {
                Console.Write("Insira o nome do país " + (i + 1) + ": ");
                paises[i] = Console.ReadLine();
            }

            Array.Sort(paises);
            Array.Reverse(paises);
            Console.WriteLine("\nLista de países em ordem alfabética reversa:");
            foreach (string pais in paises)
            {
                Console.WriteLine(pais);
            }

            Console.ReadLine();
        }
    }
}
