using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("9 - Condicionais");

        int idade = 16;
        bool maioridade = idade > 18;
        bool acompanhado = false;
        string status;

        if (acompanhado == true)
        {
            status = "Está acompanhado(a)";
        }
        else
        {
            status = "Não está acompanhado(a)";
        }

        // or = ||     and = &&
        if (maioridade || acompanhado)
        {
            Console.WriteLine("Entrada liberada. " + status);
        }

        else
        {
            Console.WriteLine("Entrada não permitida. " + status);
        }

        Console.WriteLine("Pressione Enter para finalizar:");
        Console.ReadLine();
    }
}