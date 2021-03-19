//
//               #######################################
//               #                                     #
//               #       x |                           #
//               #         |                           #
//               #         |--------                   #
//               #                y                    #
//               #                                     #
//               #######################################
//
//
using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            bool exit = false;
            double frameRate = 1000 / 10.0;
            DateTime lastDate = DateTime.Now;
            Meal meal = new Meal();
            Snake snake = new Snake();
            while(!exit)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey();
                    
                    switch(input.Key)
                    {
                        case ConsoleKey.Escape:
                            exit = true;
                            break;
                        case ConsoleKey.LeftArrow:
                            snake.Direction = Direction.Left;
                            break;
                        case ConsoleKey.RightArrow:
                            snake.Direction = Direction.Right;
                            break;
                        case ConsoleKey.UpArrow:
                            snake.Direction = Direction.Up;
                            break;
                        case ConsoleKey.DownArrow:
                            snake.Direction = Direction.Down;
                            break;

                    }
                }
                if((DateTime.Now - lastDate).TotalMilliseconds >= frameRate)
                {

                    snake.Move();

                    if(meal.CurrentTarget.X == snake.HeadPosition.X && meal.CurrentTarget.Y == snake.HeadPosition.Y)
                    {
                        snake.eatMeal();
                        meal = new Meal();
                        frameRate /= 1.1;
                    }
                    lastDate = DateTime.Now;
                    if(snake.GameOver)
                    {
                        Console.Clear();
                        exit = true;
                        Console.WriteLine($"Koniec Gry Twój wynik to { snake.Lenght }");
                        Console.ReadLine();
                    }
                }

            }
        }
    }
}
