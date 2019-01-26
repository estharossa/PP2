using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            //string s1 = Console.ReadLine();
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = int.Parse(s1);

            //string s = Console.ReadLine();
            //string[] arr = s.Split();
            //int a = int.Parse(arr[0]);

            string[] arr = Console.ReadLine().Split(',');
            int sum = 0;
            for (int i=0; i < arr.Length; i++)
            {
                sum = sum + int.Parse(arr[i]);
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
