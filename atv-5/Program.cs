using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números você deseja inserir?");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[quantidade];
            int soma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Insira o número " + (i + 1) + ": ");
                string entrada = Console.ReadLine();

                // Verifica se a entrada é um número válido
                if (int.TryParse(entrada, out int numero))
                {
                    numeros[i] = numero;
                    soma += numero;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                    i--; // Reduz o contador para repetir a tentativa de inserção
                }
            }

            Console.WriteLine("\nA soma de todos os números na matriz é: " + soma);

            Console.ReadLine();
        }
    }
}
