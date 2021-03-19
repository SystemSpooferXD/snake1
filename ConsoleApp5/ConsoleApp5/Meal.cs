using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Meal
    {
        public Meal()
        {
            Random rand = new Random();
            var x = rand.Next(0, 20);
            var y = rand.Next(1, 20);
            CurrentTarget = new Coordinate(x, y);
            Draw();
        }

        public Coordinate CurrentTarget { get; set; }

        void Draw()
        {
            Console.SetCursorPosition(CurrentTarget.X, CurrentTarget.Y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("$");
        }
    }
}
