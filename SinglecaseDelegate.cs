using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class SinglecaseDelegate
    {
        public delegate int MyDelegate(int x, int y);

        public class Program
        {
            static int Sum(int x, int y)
            {
                return x + y;
            }

            static int Sub(int x, int y)
            {
                return x - y;
            }

            static int Mul(int x, int y)
            {
                return x * y;
            }

            static int Div(int x, int y)
            {
                if (y != 0)
                {
                    return x / y;
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                    return 0; // You can handle this case however you want
                }
            }

            public static void Main(string[] args)
            {
                Console.WriteLine("Enter A and B values");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());

                Console.WriteLine("Select an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");

                int choice = int.Parse(Console.ReadLine());
                MyDelegate delegateObject = null;

                switch (choice)
                {
                    case 1:
                        delegateObject = Sum;
                        break;
                    case 2:
                        delegateObject = Sub;
                        break;
                    case 3:
                        delegateObject = Mul;
                        break;
                    case 4:
                        delegateObject = Div;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                if (delegateObject != null)
                {
                    int result = delegateObject(a, b);
                    Console.WriteLine("Result: " + result);
                }

                Console.ReadKey();
            }
        }
    }
}
