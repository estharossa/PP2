using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Ex3
{
    class MyThread
    {
        public static object locker = new object();
        Thread threadField;
        public MyThread(string name)
        {
            threadField = new Thread(Count);
            this.threadField.Name = name;
        }
        public void StartThread()
        {
           
            threadField.Start();
        }

        public void Count()
        {
            lock (locker) {
                for (int i = 1; i < 5; i++)
                {

                    Console.WriteLine(Thread.CurrentThread.Name + " Выводит " + i);
                    if (i == 4)
                        Console.WriteLine(Thread.CurrentThread.Name + " Заверишлся");
                    Thread.Sleep(1000);
                }
            }
            
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            
            MyThread t1 = new MyThread("Thread 1");
            MyThread t2 = new MyThread("Thread 2");
            MyThread t3 = new MyThread("Thread 3");
            t1.StartThread();
            t2.StartThread();
            t3.StartThread();
            Console.ReadKey();
        }
    }
}
