using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("12 - Investimento");
        double rendimento = 1.005;
        double investimento = 1000;
        int anosInvestimento = 5;

        for (int ano = 1; ano <= anosInvestimento; ano++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= rendimento;
            }

            rendimento += 0.001;
        }   

        Console.WriteLine("Depois de " + anosInvestimento + " anos, você terá R$" + investimento);

        Console.WriteLine("Pressione Enter para encerrar:");
        Console.ReadLine();
    }
}
