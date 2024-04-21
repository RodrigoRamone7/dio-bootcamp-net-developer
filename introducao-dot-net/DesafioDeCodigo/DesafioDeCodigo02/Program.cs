using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Lista para armazenar os itens
        List<string> itens = new List<string>();

        // TODO: Solicite os itens ao usuário
        Console.WriteLine("Insira o nome de 3 Itens.");
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Item Nº { i+1 }");
            string item = Console.ReadLine();
            itens.Add(item);
        }

        // Exibe a lista de itens
        Console.WriteLine("Lista de itens:");
        foreach (string item in itens)
        {
            Console.WriteLine($"- {item}");
        }
    }
}