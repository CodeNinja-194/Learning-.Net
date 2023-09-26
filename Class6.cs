using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class6
    {
        static void main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = Add(a, b);
            System.Console.WriteLine("{0}+{1}={2}", a,b,sum);
            Console.ReadKey();
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
