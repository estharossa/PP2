using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(showTime);
            thread.Start();
            Console.ReadKey();
        }

        static void showTime()
        {
            while (true)
            {
                Console.Clear();
                DateTime time = DateTime.Now;
                Console.WriteLine(time);
                Thread.Sleep(1000);
            }
        }
    }
    }

