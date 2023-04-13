using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("10 - laços de repetição While");

        double investimento = 1000;
        double rendimento;

        int mes = 1;

        while (mes <= 12)
        {
            rendimento = investimento * 0.005;
            investimento += rendimento;
            Console.WriteLine("No mês " + mes + " você tem R$" + investimento);
            mes++;
        }


        Console.WriteLine("Pressione Enter para finalizar: ");
        Console.ReadLine();
    }
}