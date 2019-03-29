using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Xml.Serialization;
namespace Snake
{
    class Program
    {
        public static Game game = new Game();
        static void Main(string[] args)
        {

            
            Console.SetWindowSize(60, 20);
            Console.CursorVisible = false;

            game.Start();
           

        }
        
    }
}
