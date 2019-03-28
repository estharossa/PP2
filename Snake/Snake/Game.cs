using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
namespace Snake
{
    [Serializable]
    public class Game
    {
        List<GameObject> g_objects;
        public bool isAlive;
        public Snake snake;
        public Food food;
        public Wall wall;
        public Borders borders;

        public Game()
        {
            g_objects = new List<GameObject>();
            snake = new Snake(20, 10, '*', ConsoleColor.White);
            food = new Food(0, 0, 'o', ConsoleColor.Cyan);
            wall = new Wall('#', ConsoleColor.Green);
            borders = new Borders('#', ConsoleColor.Red);
            borders.addBorders();
            wall.LoadLevel();
            while (food.IsCollisionWithObject(snake) || food.IsCollisionWithObject(wall) || food.IsCollisionWithObject(borders))
                food.Generate();

            g_objects.Add(snake);
            g_objects.Add(food);
            g_objects.Add(wall);
            g_objects.Add(borders);
            isAlive = true;
        }

        public void Start()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Thread thread = new Thread(MoveSnake);
            thread.Start();

            while (isAlive && keyInfo.Key != ConsoleKey.Escape)
            {
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.S)
                {
                    Save();
                    snake.Move();

                }
                if (keyInfo.Key == ConsoleKey.R)
                {
                    Resume();

                    Console.Clear();
                }
                snake.ChangeDirection(keyInfo);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("GAME OVER!!!");
            Console.ReadKey();

        }

        public void MoveSnake()
        {
            while (isAlive)
            {
                snake.Move();
                if (snake.IsCollisionWithObject(food))
                {
                    snake.body.Add(new Point(0, 0));
                    while (food.IsCollisionWithObject(snake) || food.IsCollisionWithObject(wall))
                        food.Generate();

                    if (snake.body.Count % 3 == 0)
                        wall.NextLevel();
                }
                if (snake.IsCollisionWithObject(wall) || snake.IsCollisionWithObject(borders)) 
                {
                    isAlive = false;
                }
                Draw();
                Thread.Sleep(200);
            }
        }
        public void Draw()
        {
            Console.Clear();
            foreach (GameObject g in g_objects)
                g.Draw();
        }

        public void Save()
        {
            File.Delete("game.xml");
            FileStream fs = new FileStream("game.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Game));
            xs.Serialize(fs, Program.game);
            Console.SetCursorPosition(30, 30);
            Console.WriteLine("Saved");
            fs.Close();
        }
        public void Resume()
        {
            Console.SetCursorPosition(50, 10);
            Console.Write("GGGGGGGGGGGGG");
            FileStream fs = new FileStream("game.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Game));
            Program.game = (Game)xs.Deserialize(fs);
            fs.Close();
        }
    }
        
    }

