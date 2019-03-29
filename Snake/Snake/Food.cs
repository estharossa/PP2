using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace Snake
{
    public class Food:GameObject
    {
        public Food(int x, int y, char sign, ConsoleColor color) : base(x, y, sign, color)
        {
        }
        public Food()
        {

        }
        public void Generate()
        {
            Random random = new Random();
            int x = random.Next(1, Console.WindowWidth-1);
            int y = random.Next(1, Console.WindowHeight-1);
            body[0].x = x;
            body[0].y = y;
        }
        /*
        public void Save()
        {

            FileStream fs = new FileStream("food.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Food));
            xs.Serialize(fs, Program.game.food);
            Console.WriteLine("Saved");
            fs.Close();
        }
        public void Resume()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Food));
            FileStream fs = new FileStream("food.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Program.game.food = xs.Deserialize(fs) as Food;

        }
        */
    }
}
