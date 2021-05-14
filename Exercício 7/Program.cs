using System;

namespace Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[15];
            Console.WriteLine("\nDigite 15 números diferentes:");

            for (var i = 0; 15>i; i++)
            {
                numeros[i] = int.Parse (Console.ReadLine());
            }

            Console.WriteLine("\nLista de números invertida: ");

            Array.Reverse(numeros);
            for (var i = 0; 15>i; i++)
            {
                Console.WriteLine("" + numeros[i]);
            }
        }
    }
}
