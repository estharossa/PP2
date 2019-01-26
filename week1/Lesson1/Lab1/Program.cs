using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    
    class Program
    {
        public static bool IsPrime(int k)
        {
            for (int i = 2; i * i < k; i++)
            {
                if (k % i == 0)
                {
                    return true;
                }
            }
            return false;
        }


        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i=0; i < n; i++)
            {
                int l = int.Parse(Console.ReadLine());
                a[i] = l;
            }
            foreach (int c in a)
            {
                if (IsPrime(c) == false)
                {
                    Console.WriteLine(c);
                }
            }
            Console.ReadKey();
        }
    }
}
