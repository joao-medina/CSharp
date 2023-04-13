using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("2 - Variáveis do tipo inteiro");

        int idade;
        idade = 27 - 5;
        Console.WriteLine(idade);
        Console.WriteLine("A idade é " + idade);


        Console.Write("A idade é ");
        Console.WriteLine(idade);

        Console.WriteLine("Pressione enter para encerrar: ");
        Console.ReadLine();
    }
}