using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public delegate void MyDelegate1(int a, int b);
    class MultiCastingDelegates
    {
        static void main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int b = Convert.ToInt32(Console.ReadLine());
            MyDelegate1 d1 = Calculator1.Add;
            MyDelegate1 d2 = Calculator1.Sub;
            MyDelegate1 d3 = Calculator1.Mul;
            MyDelegate1 d4 = Calculator1.Div;
            d1 += d2 + d3 + d4;
            d1(a, b);
            Console.ReadKey();
        }

    }
    class Calculator1
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition of " + a + " and " + b + " is " + (a + b));
        }

        public static void Sub(int a, int b)
        {
            Console.WriteLine("Subtraction of " + a + " and " + b + " is " + (a - b));
        }

        public static void Mul(int a, int b)
        {
            Console.WriteLine("Multiplication of " + a + " and " + b + " is " + (a * b));
        }

        public static void Div(int a, int b)
        {
            Console.WriteLine("Division of " + a + " and " + b + " is " + (a / b));
        }
    }
}