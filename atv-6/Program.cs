using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas cidades você deseja inserir?");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            List<string> cidades = new List<string>();

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Insira o nome da cidade " + (i + 1) + ": ");
                cidades.Add(Console.ReadLine());
            }

            cidades = cidades.Where(cidade => !cidade.StartsWith("S", StringComparison.OrdinalIgnoreCase)).ToList();

            Console.WriteLine("\nLista de cidades atualizada:");
            foreach (string cidade in cidades)
            {
                Console.WriteLine(cidade);
            }

            Console.ReadLine(); 
        }
    }
}
