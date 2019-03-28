using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Animal
    {
        string name;
        int age;

        public Animal()
        {
            this.name = Console.ReadLine();
            this.age = int.Parse(Console.ReadLine());
        }

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void getInfo()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Age: " + this.age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            Animal dog = new Animal("Axe", 12);
            cat.getInfo();
            dog.getInfo();
            Console.ReadKey();
        }
    }
}
