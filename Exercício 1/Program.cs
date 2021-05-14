using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n" + "Digite seu ano de nascimento: ");
            int anoNascimento = int.Parse (Console.ReadLine());
            int anoAtual = DateTime.Now.Year;
            int idade = anoAtual - anoNascimento;

            if (idade > 15 & idade < 18)
            {
                Console.WriteLine("\n" + "Você tem mais de 16 anos, então já pode votar, mas não obrigatóriamente." + "\n");
            }
            else if (idade > 17 & idade < 120)
            {
                Console.WriteLine("\n" + "Você tem mais de 18 anos, então seu voto é obrigatório." + "\n");
            }
            else if (idade > 119)
            {
                Console.WriteLine("\n" + "Não era para você estar vivo ;-;" + "\n");
            }
            else
            {
                Console.WriteLine("\n" + "Você é menor de 16 anos, então ainda não pode votar." + "\n");
            }
        }
    }
}
