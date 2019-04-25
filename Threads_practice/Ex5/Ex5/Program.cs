using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Ex5
{
    class Program
    {
        static void sin()
        {

            double coord;
            for (int x = 0; x < 100; x++)
            {
                if (x % 3 == 1)
                {
                    coord = Math.Cos(x * 2) * 20;
                    int y = Convert.ToInt32(coord);
                    Console.SetCursorPosition(x+20, y+20);
                    Console.WriteLine('*');
                    Thread.Sleep(200);
                }

            }
        }
        static void Main(string[] args)
        {


            Thread thread = new Thread(sin);
            thread.Start();

            Console.ReadKey();


        }
    }
}
