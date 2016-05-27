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

            Horisontal upLine = new Horisontal(0, 98, 0, '=');
            Horisontal downLine = new Horisontal(0, 98, 49, '=');
            Vertical leftLine = new Vertical(0, 49, 0, 'l');
            Vertical rightLine = new Vertical(0, 49, 98, 'l');
            upLine.Drow();
            downLine.Drow();
            leftLine.Drow();
            rightLine.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(100, 50, '@');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
             if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
             else
                {
                    snake.Move();
                }

                Thread.Sleep(200);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handlekey(key.Key);
                }

                snake.Move();
            }
            
        }
    }
}
