﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace Snake
{
    public class GameObject
    {
        public List<Point> body;
        public char sign;
        public ConsoleColor color;

        public GameObject(int x, int y, char sign, ConsoleColor color)
        {
           
            body = new List<Point>
            {
                new Point(x, y)
            };

            this.sign = sign;
            this.color = color;
        }
        public GameObject()
        {

        }
        
        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                try
                {
                    Console.SetCursorPosition(p.x, p.y);
                    Console.Write(sign);
                }
                catch 
                {
                   
                }
            }
        }

        public bool IsCollisionWithObject(GameObject obj)
        {
            foreach (Point p in obj.body)
            {
                if (body[0].x == p.x && body[0].y == p.y)
                    return true;
            }
            return false;
        }
        

    }
}
