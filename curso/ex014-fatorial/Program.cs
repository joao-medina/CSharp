using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("================"); 
        Console.WriteLine("=   Fatorial   =");
        Console.WriteLine("================");

        int numero = 4;
        int numeroInicial = numero;

        for(int cont = numero - 1 ; cont > 0; cont--)
        {
            numero *= cont;
        }

        Console.WriteLine("O Fatorial de " + numeroInicial + " é " + numero);

        Console.WriteLine("Pressione Enter para encerrar:");
        Console.ReadLine();
    }
}