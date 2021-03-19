using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Coordinate
    {
        public Coordinate()
        {
            X = 0;
            Y = 0;
        }

        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }
    }
}
