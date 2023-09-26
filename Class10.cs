using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public delegate void MyDelegate(string msg);
    class ClassA
    {
        public static void methodA(string msg)
        {
            Console.WriteLine("Method A of Class A:"+msg);
        }
    }
    class ClassB
    {
        public static void methodB(string msg)
        {
            Console.WriteLine("Method B of Class B:"+msg);
        }
    }
    class Class10
    {
        public static void main(string[] args)
        {
            MyDelegate del=ClassA.methodA;
            //MyDelegate del = new MyDelegate(ClassA.methodA);
            del("Hello World");
            del = ClassB.methodB;
            del("WELCOME");
            del = (string msg) => Console.WriteLine("called Lambda Expression" + msg);
            Console.ReadKey();
        }
    }
   

}
