using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Task1
    {
            public static bool IsPrime(int k)
            {
            
                for (int i = 2; i <= Math.Sqrt(k); i++)
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
            
            List<string> list = new List<string>();
            int n = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split();
                foreach (string z in arr)
            {
                if (IsPrime(int.Parse(z)) == false)
                {
                    if (int.Parse(z) == 1) continue;
                    list.Add(z);
                }
            }
            Console.WriteLine(list.Count);
            foreach(string a in list)
            {
                Console.Write(a + " ");
            }
            Console.ReadKey();
            }
    }
}
