using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nVocê deseja abastecer com álcool ou gasolina? Digite A se quiser Álcool ou G se quiser Gasolina.");
            string combustivel = (Console.ReadLine());

            Console.WriteLine("\nCom quantos litros de combustível você deseja abastecer seu veículo?");
            int litros = int.Parse(Console.ReadLine());
            double precoLitroGas = 5.3;
            double precoLitroAlc = 4.9;

            switch (combustivel)
            {
                case "a":
                    if (litros > 20)
                    {
                        double preco = System.Math.Round((litros * precoLitroAlc) - (litros * (precoLitroAlc / 100 * 5)), 2);
                        Console.WriteLine("\nSeu combustível custará R$ " + preco + ".\n");
                    }

                    else
                    {
                        double preco = System.Math.Round((litros * precoLitroAlc) - (litros * (precoLitroAlc / 100 * 3)), 2);
                        Console.WriteLine("\nSeu combustível custará R$ " + preco + ".\n");
                    }
                    break;

                case "A":
                    if (litros > 20)
                    {
                        double preco = System.Math.Round((litros * precoLitroAlc) - (litros * (precoLitroAlc / 100 * 5)), 2);
                        Console.WriteLine("\nSeu combustível custará R$ " + preco + ".\n");
                    }

                    else
                    {
                        double preco = System.Math.Round((litros * precoLitroAlc) - (litros * (precoLitroAlc / 100 * 3)), 2);
                        Console.WriteLine("\nSeu combustível custará R$ " + preco + ".\n");
                    }
                    break;

                case "g":
                    if (litros > 20)
                    {
                        double preco = System.Math.Round((litros * precoLitroGas) - (litros * (precoLitroGas / 100 * 6)), 2);
                        Console.WriteLine("\nSeu combustível custará R$ " + preco + ".\n");
                    }

                    else
                    {
                        double preco = System.Math.Round((litros * precoLitroGas) - (litros * (precoLitroGas / 100 * 4)), 2);
                        Console.WriteLine("\nSeu combustível custará R$ " + preco + ".\n");
                    }
                    break;

                case "G":
                    if (litros > 20)
                    {
                        double preco = System.Math.Round((litros * precoLitroGas) - (litros * (precoLitroGas / 100 * 6)), 2);
                        Console.WriteLine("\nSeu combustível custará R$ " + preco + ".\n");
                    }

                    else
                    {
                        double preco = System.Math.Round((litros * precoLitroGas) - (litros * (precoLitroGas / 100 * 4)), 2);
                        Console.WriteLine("\nSeu combustível custará R$ " + preco + ".\n");
                    }
                    break;

                default:
                    Console.WriteLine("\nEsse não é um tipo de combustível.\n");
                    break;
            }

        }
    }
}
