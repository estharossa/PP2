using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace Snake
{
    [Serializable]
    public class Snake:GameObject
    {
        public enum Direction
        {
            NONE,
            RIGHT,
            LEFT,
            UP,
            DOWN
        }
        Direction direction = Direction.NONE;
        public Snake(int x, int y, char sign, ConsoleColor color) : base(x, y, sign, color)
        {

        }
        public Snake()
        {

        }
        public void Move()
        {
            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            if (direction == Direction.UP)
                body[0].y--;
            if (direction == Direction.DOWN)
                body[0].y++;
            if (direction == Direction.LEFT)
                body[0].x--;
            if (direction == Direction.RIGHT)
                body[0].x++;



        }

        public void ChangeDirection(ConsoleKeyInfo keyInfo)
        {
           
                
                if (keyInfo.Key == ConsoleKey.UpArrow)
                    direction = Direction.UP;
                if (keyInfo.Key == ConsoleKey.DownArrow)
                    direction = Direction.DOWN;
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    direction = Direction.LEFT;
                if (keyInfo.Key == ConsoleKey.RightArrow)
                    direction = Direction.RIGHT;
            if (keyInfo.Key == ConsoleKey.S)
                direction = Direction.NONE;
            
        }
        /*
        public void Save()
        {

            FileStream fs = new FileStream("snake.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Snake));
            xs.Serialize(fs, Program.game.snake);
            Console.WriteLine("Saved");
            fs.Close();
        }
        public void Resume()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Snake));
            FileStream fs = new FileStream("snake.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Program.game.snake = xs.Deserialize(fs) as Snake;

        }
        */
    }
}
