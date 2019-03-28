using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex2
{
        class Program
        {
        static void mythread()
        {
            for (int c = 0; c <= 3; c++)
            {

                Console.WriteLine("mythread is in progress!!");
                Thread.Sleep(3000);
            }
            Console.WriteLine("mythread ends!!");
        }
        static void Main(string[] args)
            {
            Thread thr = new Thread(mythread);
            thr.Start();
            Console.WriteLine("Main Thread Ends!!");
            Console.ReadKey();
        }
        }
    }

