using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp5
{
    public class Snake : ISnake
    {
        public int Lenght { get; set; } = 1;
        public Direction Direction { get; set; } = Direction.Right;
        public Coordinate HeadPosition { get; set; } = new Coordinate();
        List<Coordinate> Tail { get; set; } = new List<Coordinate>();
        private bool outOfRange = false;

        public bool GameOver
        {
            get { return (Tail.Where(c => c.X == HeadPosition.X && c.Y == HeadPosition.Y).ToList().Count > 1) || outOfRange; }
        }
        public void eatMeal()
        {
            Lenght++;
        }

        public void Move()
        {
            switch(Direction)
            {
                case Direction.Left:
                    HeadPosition.X--;
                    break;

                case Direction.Right:
                    HeadPosition.X++;
                    break;

                case Direction.Up:
                    HeadPosition.Y--;
                    break;

                case Direction.Down:
                    HeadPosition.Y++;
                    break;
            }
            try
            {
                Console.SetCursorPosition(HeadPosition.X, HeadPosition.Y);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("@");
                Tail.Add(new Coordinate(HeadPosition.X, HeadPosition.Y));
                if(Tail.Count > this.Lenght)
                {
                    var endTail = Tail.First();
                    Console.SetCursorPosition(endTail.X, endTail.Y);
                    Console.Write(" ");
                    Tail.Remove(endTail);
                }
            }
            catch(ArgumentOutOfRangeException)
            {
                outOfRange = true;
            }


        }
    }


    public enum Direction { Left, Right, Up, Down}
}
