using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("12 - Comando BREAK");

        int coluna = 0;

        for (int linha = 0; linha < 20; linha++)
        {
            while(true)
            {
                Console.Write("*");
                coluna++;
                if (coluna > linha)
                {
                    break;
                }
            }
            Console.WriteLine();
            coluna = 0;
        }

        Console.WriteLine("Pressione Enter para encerrar:");
        Console.ReadLine();
    }
}