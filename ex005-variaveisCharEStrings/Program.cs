using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("5 - Srings");

        char letra;
        letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        char segundaLetra = (char)66;
        Console.WriteLine(segundaLetra);

        string frase;
        frase = "Frase aleatória";
        Console.WriteLine(frase);

        string linguagens;
        linguagens = @"Linguagens de programação:
- Java 
- Python 
- C 
- C++ 
- C# ";
        Console.WriteLine(linguagens);

        Console.WriteLine("Pressione enter para encerrar: ");
        Console.ReadLine();
    }
}

