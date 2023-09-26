using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Method overloading to perform 2,3,4,numbers using static functions
namespace ConsoleApplication1
{
    class Class11
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Enter the Four Numbers");
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum =int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Largest of two Numbers :"+LgNum(firstNum, secondNum));
            Console.WriteLine("Largest of three Numbers :"+LgNum(firstNum, secondNum, thirdNum));
            Console.WriteLine("Largest of four Numbers :"+LgNum(firstNum, secondNum, thirdNum, fourthNum));

            Console.Write("\nPress enter...");
            Console.ReadKey();
    }

    public static int LgNum(int num1, int num2)
    {
        int[] numbers = { num1, num2 };
        return numbers.Max();

    }

    public static int LgNum(int num1, int num2, int num3)
    {
        int[] numbers = { num1, num2, num3 };
        return numbers.Max();
    }

    public static int LgNum(int num1, int num2, int num3, int num4)
    {
        int[] numbers = { num1, num2, num3, num4 };
        return numbers.Max();
    }
    }
}
