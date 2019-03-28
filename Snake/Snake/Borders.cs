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
    public class Borders : GameObject
    {
        public Borders(char sign, ConsoleColor color) : base(0, 0, sign, color)
        {
            body = new List<Point>();

        }
        public Borders()
        {

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
        /*
        public void Save()
        {

            FileStream fs = new FileStream("borders.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Borders));
            xs.Serialize(fs, Program.game.borders);
            Console.WriteLine("Saved");
            fs.Close();
        }
        public void Resume()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Borders));
            FileStream fs = new FileStream("borders.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Program.game.borders = xs.Deserialize(fs) as Borders;
            
        }
        */
    }
}
