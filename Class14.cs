using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class14
    {
        public static void main(string[] args)
        {
            ExplicitConstructor obj1 = new ExplicitConstructor();
            ExplicitConstructor obj2 = new ExplicitConstructor();
            ExplicitConstructor obj3 = new ExplicitConstructor();
            ExplicitConstructor obj4 = new ExplicitConstructor();
            Console.ReadKey();
        }
    }
    class ExplicitConstructor
    {
        public ExplicitConstructor()
        {
            Console.WriteLine("Explicit Constructor is Called!");
        }
    }
}
