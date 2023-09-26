using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Rectangle
    {
        public int l;
        public int b;
        public int Area()
        {
            return l * b;
        }
    }
    class Class2
    {
        static void main(string[] args)
        {
            Rectangle ob = new Rectangle();
            ob.l = 10;
            ob.b = 10;
            Console.WriteLine("Area of the Rectangle is:{0}", ob.Area());
            Console.ReadKey();
        }
    }
}
