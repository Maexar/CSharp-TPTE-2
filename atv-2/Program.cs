using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Quantos animais você deseja inserir?");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] animais = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Insira o nome do animal:");
                animais[i] = Console.ReadLine();
            }

            Console.WriteLine("\nNomes dos animais inseridos:");
            foreach (string animal in animais)
            {
                Console.WriteLine(animal);
            }

            int count = animais.Count(animal => animal.StartsWith("C", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"\nNúmero de animais cujo nome começa com 'C': {count}");

            Console.ReadLine();
        }
    }
}