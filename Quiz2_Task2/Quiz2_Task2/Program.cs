using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Task2
{
    [Serializable]
    public class Employee
    {
        public string name;
        public int wage;

        public Employee()
        {

        }

        public Employee(string name, int wage)
        {
            this.name = name;
            this.wage = wage;
        }

    }

    class Program
    {
        static void Serialize(List<Employee> list)
        {


            FileStream fs = new FileStream("employee.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(List<Employee>));
            xs.Serialize(fs, list);
            Console.WriteLine("Serialized");
            fs.Close();


        }
        static void Deserialize()
        {

            FileStream fs = new FileStream("employee.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(List<Employee>));
            List<Employee> list = new List<Employee>();
            list = xs.Deserialize(fs) as List<Employee>;
            foreach (Employee e in list)
            {
                Console.WriteLine(e);
            }
            fs.Close();
        }


        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.D1)
                {
                    if (!File.Exists("employee.xml"))
                        Console.WriteLine("List is empty");
                    Console.WriteLine("Employees:");
                    Deserialize();
                }
                if (keyInfo.Key == ConsoleKey.D2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Enter the name and wage");
                    string name = Console.ReadLine();
                    int wage = int.Parse(Console.ReadLine());
                    Employee e = new Employee(name, wage);
                    list.Add(e);
                    Serialize(list);
                }
            }

        }
    }
}
