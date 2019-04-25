using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(print);
            thread.Start();
            Console.ReadKey();
        }
        static void print()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.SetCursorPosition(10, 10);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(i + 1);
                Thread.Sleep(1000);
            }
        }
    }
}
