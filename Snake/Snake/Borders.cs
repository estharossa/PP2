using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class Borders : GameObject
    {
        public Borders(char sign, ConsoleColor color) : base(0, 0, sign, color)
        {
            body = new List<Point>();

        }
        int a = Console.WindowHeight;
        int b = Console.WindowWidth;
        public void addBorders()
        {
            for (int i = 0; i < a; i++)
            {
                body.Add(new Point(0, i));
            }
            for (int i = 0; i < b; i++)
            {
                body.Add(new Point(i, 0));
            }
            for (int i = 0; i < b; i++)
            {
                body.Add(new Point(i, a-1));
            }
            for (int i = 0; i < a; i++)
            {
                body.Add(new Point(b-1, i));
            }
        }
    }
}
