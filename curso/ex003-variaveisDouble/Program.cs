using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("3 - Variáveis double.");

        double salario;
        salario = 3000.50;

        double idade;
        idade = 7.0 / 2;
        Console.WriteLine(idade);

        Console.WriteLine("O salário é de R$" + salario);

        Console.WriteLine("Pressione enter para encerrar: ");
        Console.ReadLine();

    }
}
