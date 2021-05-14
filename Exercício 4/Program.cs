using System;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nDigite 10 números");
            int[] numeros = new int[10];

            for (var i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numeros);

            Console.WriteLine($"\nO menor número é: {numeros[0]}");
            Console.WriteLine($"O maior número é: {numeros[9]}\n");
        }
    }
}
