using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Quantas cores você deseja inserir?");
        int quantidade = Convert.ToInt32(Console.ReadLine());
        List<string> cores = new List<string>();

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write("Insira o nome da cor " + (i + 1) + ": ");
            cores.Add(Console.ReadLine().ToLower());
        }

        int contagem = cores.Count(cor => cor == "vermelho" || cor == "azul" || cor == "amarelo");

        Console.WriteLine("\nNúmero de cores primárias na lista: " + contagem);
    }
}