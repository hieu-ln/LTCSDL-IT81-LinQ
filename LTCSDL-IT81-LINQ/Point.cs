using System;
using System.Collections.Generic;
using System.Text;

namespace LTCSDL_IT81_LINQ
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
        }
        public Point() { }
        public void DisplayStats()
        {
            Console.Write("[{0}, {1}]", X, Y);
        }
    }
}
