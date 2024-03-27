using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos países você deseja inserir?");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            List<string> paises = new List<string>();

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Insira o nome do país " + (i + 1) + ": ");
                paises.Add(Console.ReadLine());
            }

            int contagem = paises.Count(pais => pais.Length > 10);

            Console.WriteLine("\nNúmero de países com mais de 10 letras: " + contagem);

            Console.ReadLine();
        }
    }
}
