using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            const int height = 20;
            const int width = 60;
            
            Console.SetWindowSize(width, height);
            Console.CursorVisible = false;
            Game game = new Game();
           
            game.Start();
           
           
            
            //Console.ReadKey();
        }
        
    }
}
