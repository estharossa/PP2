using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] a = s.Split(); // creating array from string
            List<string> list = new List<string>(); // creating the list
            foreach (string k in a) // using loop to fill the list
            {
                list.Add(k); // adding twice to the list
                list.Add(k);
            }
            foreach (string k in list)
            {
                Console.Write(k + " "); // outputting the list

            }

            Console.ReadKey();
        }
    }
}