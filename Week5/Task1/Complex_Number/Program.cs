using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace Complex_Number
{
    public class ComplexNum
    {
        public int a, b;

        public ComplexNum() { }
        public ComplexNum(int x, int y)
        {
            this.a = x;
            this.b = y;
        }
        public override string ToString()
        {
            if (b < 0)
            {
                return String.Format(a + " - " + b + "i");
            }
            else if (b > 0)
            {
                return String.Format(a + " + " + b + "i");
            }
            else
                return String.Format(a.ToString());

        }
    }

      
        class Program
    {
        public static void Serialize(ComplexNum a)
        {
            if (File.Exists("complex.xml"))
            {
                File.Delete("complex.xml");
            }
            FileStream fs = null;
            XmlSerializer xs = new XmlSerializer(typeof(ComplexNum));
            try
            {
                fs = new FileStream("complex.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                
                xs.Serialize(fs, a);
                Console.WriteLine("Serialized");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                fs.Close();
            }
        }
        public static void Deserialize()
        {
            XmlSerializer xs = new XmlSerializer(typeof(ComplexNum));
            FileStream fs = null;
            try
            {
                fs = new FileStream("complex.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                ComplexNum a = xs.Deserialize(fs) as ComplexNum;
                Console.WriteLine("Deserialized");
                Console.WriteLine(a);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                fs.Close();
            }
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            ComplexNum c1 = new ComplexNum(a, b);
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.S)
            {
                Serialize(c1);
            }
            ConsoleKeyInfo keyInfo1 = Console.ReadKey();
            if (keyInfo1.Key == ConsoleKey.R)
            {
                Deserialize();
            }
            
            Console.ReadKey();
        }
    }
}
