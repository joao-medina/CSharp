using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("4 - Conversão de Variáveis");

        double salario;
        salario = 1800.50;

        int salarioInteiro;
        salarioInteiro = (int)salario;

        Console.WriteLine("O salário é de R$" + salarioInteiro);

        int x = 1000000000;

        long y = 1000000000000000000;

        short z = 10000;

        float t = 1.00f;

        Console.WriteLine("Pressione enter para encerrar: ");
        Console.ReadLine();
    }
}