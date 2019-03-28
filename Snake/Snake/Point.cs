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
    public class Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point()
        {

        }
        public void Save()
        {

            FileStream fs = new FileStream("point.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Point));
            xs.Serialize(fs, Program.game);
            Console.WriteLine("Saved");
            fs.Close();
        }
    }
}
