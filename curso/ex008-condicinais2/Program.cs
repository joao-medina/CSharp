using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("8 - Condicionais");

        int idade = 16;

        bool maioridade = idade > 18;
        bool acompanhado = true;

        // or = ||     and = &&
        if (maioridade || acompanhado)
        {
            Console.WriteLine("Entrada liberada.");
        }

        else
        {
            Console.WriteLine("Entrada não permitida");
        }

        Console.WriteLine("Pressione Enter para finalizar:");
        Console.ReadLine();
    }
}