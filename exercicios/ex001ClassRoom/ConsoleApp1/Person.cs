using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {

        private int age;

        public void SetAge(int n)
        {
            age = n;
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is " + this.age);
        }

    }
}
