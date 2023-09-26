using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.ForegroundColor = ConsoleColor.Green;
            int n=123;
            int myNum = 5;
            int n1 = n + myNum;
            int n2 = n - myNum;
            int n3 = n * myNum;
            int n4 = n / myNum;
            int n5 = n % myNum;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";
            Console.WriteLine(myNum+" "+myDoubleNum+" "+myLetter+" "+myBool+" "+myText);
            Console.WriteLine("HELLO welcome to my first c# application");
            Console.WriteLine("{0}+{1}={2}", myNum, n, n1);
            Console.WriteLine("{0}-{1}={2}", n, myNum, n2);
            Console.WriteLine("{0}*{1}={2}", n, myNum, n3);
            Console.WriteLine("{0}/{1}={2}", n, myNum, n4);
            Console.WriteLine("{0}%{1}={2}", n, myNum, n5);

            //Console.WriteLine("Enter value a:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine((int)a);
            //Console.WriteLine("Enter value b:");
            //Double b = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(b);
            //Console.WriteLine("Enter value c:");
            //Char c = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine(c);
            //Fact(); 
            Console.ReadKey();
        }
    }
}
