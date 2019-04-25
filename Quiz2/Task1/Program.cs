using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Task1
{
    public class Point
    {
        public int x;
        public int y;
        public Point (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
    
    class Clock
    {
        public List<Point> list;
        int i = 1;
        public Clock()
        {
            list = new List<Point>();
        }
        
        public void addCoords(Point p)
        {
            list.Add(new Point(p.x,p.y));
        }
        public void Draw()
        {
            foreach(Point p in list)
            {
                Console.SetCursorPosition(p.x, p.y);
                
                Console.WriteLine(i);
                i++;
            }
        }
        public void changeColor()
        {
            
           
              
            
            
        }
       
        public void toRed()
        {
            for (int i = 0; i < list.Count; i++)
            {

            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
           
            clock.addCoords(new Point(33, 6));
            clock.addCoords(new Point(36, 7));
            clock.addCoords(new Point(39, 8));
            clock.addCoords(new Point(36, 9));
            clock.addCoords(new Point(33, 10));
            clock.addCoords(new Point(30, 11));
            clock.addCoords(new Point(27, 10));
            clock.addCoords(new Point(24, 9));
            clock.addCoords(new Point(21, 8));
            clock.addCoords(new Point(24, 7));
            clock.addCoords(new Point(27, 6));
            clock.addCoords(new Point(30, 5));
            clock.Draw();
            Thread thread = new Thread(clock.changeColor);
            thread.Start();
            

            Console.ReadKey();
        }
    }
}
