using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas frutas você deseja inserir?");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            string[] frutas = new string[quantidade];

            for (int i = 0; i < frutas.Length; i++)
            {
                Console.Write("Insira o nome da fruta " + (i + 1) + ": ");
                frutas[i] = Console.ReadLine();
            }

            Array.Sort(frutas);
            Console.WriteLine("\nLista de frutas em ordem alfabética:");
            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            Console.ReadLine();
        }
    }
}
