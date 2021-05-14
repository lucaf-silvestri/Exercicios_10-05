using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nQual produto você deseja comprar?");
            string produto = (Console.ReadLine());

            Console.WriteLine("\nQual o preço desse produto?");
            double precoUnitario = int.Parse(Console.ReadLine());

            Console.WriteLine("\nQuantas unidades desse produto você deseja comprar?");
            int quantidade = int.Parse(Console.ReadLine());

            double total = quantidade * precoUnitario;

            if (quantidade <= 5)
            {
                double desconto = (total / 100) * 2;
                double totalAPagar = total - desconto;
                Console.WriteLine("\nO total foi de R$ " + total + ".");
                Console.WriteLine("Seu desconto será de R$ " + desconto + ".");
                Console.WriteLine("Comprando " + quantidade + " unidades do produto " + produto + ", o total a pagar será de R$ " + totalAPagar + ".\n");
            }

            else if (quantidade > 5 & quantidade <= 10)
            {
                double desconto = (total / 100) * 3;
                double totalAPagar = total - desconto;
                Console.WriteLine("\nO total foi de R$ " + total + ".");
                Console.WriteLine("Seu desconto será de R$ " + desconto + ".");
                Console.WriteLine("Comprando " + quantidade + " unidades do produto " + produto + ", o total a pagar será de R$ " + totalAPagar + ".\n");
            }

            else if (quantidade > 10)
            {
                double desconto = (total / 100) * 5;
                double totalAPagar = total - desconto;
                Console.WriteLine("\nO total foi de R$ " + total + ".");
                Console.WriteLine("Seu desconto será de R$ " + desconto + ".");
                Console.WriteLine("Comprando " + quantidade + " unidades do produto " + produto + ", o total a pagar será de R$ " + totalAPagar + ".\n");
            }

            else
            {
                Console.WriteLine("\nA quantidade informada é inválida.\n");
            }
        }
    }
}
