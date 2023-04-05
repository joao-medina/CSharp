using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("11 - Laços de Repetição For");

        double investimento = 1000;       

        for(int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine(" - No mês " + mes + " você tem R$" + investimento);
        }

        Console.WriteLine("Pressione Enter para encerrar:");
        Console.ReadLine();
    }
}
