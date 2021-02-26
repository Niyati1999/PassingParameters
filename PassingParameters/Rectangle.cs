using System;
using System.Collections.Generic;
using System.Text;

namespace PassingParameters
{
    class Rectangle
    {
        public int length { get; set; }
        public int breadth { get; set; }
        public void printData()
        {
            Console.WriteLine(length);
            Console.WriteLine(breadth);
        }
        public Rectangle()
        {
            Console.WriteLine("from constructor");
            length = 10;
            breadth = 20;
        }


    }
}
