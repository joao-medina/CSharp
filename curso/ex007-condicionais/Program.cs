using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("7 - Condicionais");

        int idade = 16;
        int pessoas = 2;

        if (idade >= 18)
        {
            Console.WriteLine("Entrada liberada.");
        }

        else
        {
            if (pessoas > 1)
            {
                Console.WriteLine("Entrada permitida por acompanhante.");
            }
            else
            {
                Console.WriteLine("Entrada não permitida");
            }
        }

        Console.WriteLine("Pressione Enter para finalizar:");
        Console.ReadLine();
    }
}