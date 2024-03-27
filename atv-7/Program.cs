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
            Console.WriteLine("Quantos números você deseja inserir?");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            List<int> numeros = new List<int>();

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Insira o número " + (i + 1) + ": ");
                numeros.Add(Convert.ToInt32(Console.ReadLine()));
            }

            numeros = numeros.Where(numero => numero % 2 == 0).ToList();

            Console.WriteLine("\nLista de números atualizada:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }


            Console.ReadLine();
        }
    }
}


