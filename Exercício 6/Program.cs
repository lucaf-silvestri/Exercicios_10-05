using System;

namespace Exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\nDigite 10 nomes diferentes");
            string[] nomes = new string[10];

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"Digite o {(i + 1)}° nome:");
                nomes[i] = Console.ReadLine();
            }

            Console.WriteLine("\nDigite o nome que deseja buscar");
            string nomeBuscar = Console.ReadLine();

            bool encontrado = false;

            foreach (var cadaNome in nomes)
            {
                if (nomeBuscar == cadaNome)
                {
                    encontrado = true;
                }
            }

            if (encontrado == true)
            {
                Console.WriteLine("\nAchei!\n");
            }

            else
            {
                Console.WriteLine("\nNão achei!\n");
            }
        }
    }
}

