using System;

namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                for (var c = 1; c < 11; c++)
                {
                    Console.WriteLine($"{i} x {c} = {i * c}");
                }
            }
        }
    }
}
