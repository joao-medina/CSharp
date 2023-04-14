using ConsoleApp1;
using System;

class Programa
{
   static void Main(string[] args){

        Person myPerson = new Person();

        Studant myStudant = new Studant();
        myStudant.GoToClasses();
        myStudant.SetAge(13);
        myStudant.ShowAge();

        Teacher myTeacher = new Teacher();
        myTeacher.Explain();
        myTeacher.SetAge(25);
        myTeacher.ShowAge();

        Console.WriteLine("Press Enter: ");
        Console.ReadLine();
    }
}