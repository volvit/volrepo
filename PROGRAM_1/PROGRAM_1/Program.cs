using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PROGRAM_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(100,50);

            Walls walls = new Walls(100, 50);
            walls.Draw();


            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(100, 50, '@');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
             else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handlekey(key.Key);
                }

            }
            WriteGameOver();
            Console.ReadLine();
            
        }

        static void WriteGameOver()
        {
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(xOffset, yOffset++);
            WriteText("======================================================", xOffset, yOffset++);
            WriteText("ППППП  РРР    ООО   И  ИИ  ГГГГГ  РРР    ААА    ЛЛЛЛ", xOffset + 1, yOffset++);
            WriteText("П   П  Р  Р  О   О  И И И  Г      Р  Р  А   А   Л  Л", xOffset + 1, yOffset++);
            WriteText("П   П  РРР   О   О  И И И  Г      РРР   ААААА   Л  Л", xOffset + 1, yOffset++);
            WriteText("П   П  Р     О   О  И И И  Г      Р     А   А   Л  Л", xOffset + 1, yOffset++);
            WriteText("П   П  Р      ООО   ИИ  И  Г      Р     А   А  Л   Л", xOffset + 1, yOffset++);
            WriteText("======================================================", xOffset, yOffset++);
        }

        static void WriteText(String text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }


    }
}
