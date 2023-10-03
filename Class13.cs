using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public class class13
    {
        public int id;
        public String name;
        public float marks;
        public class13(int i, String n, float s)
        {
            id = i;
            name = n;
            marks = s;
        }
        public class13()
        {
            this.id = 194;
            this.name = "Sai";
            this.marks = 850f;
        }
        public class13(String n, float s)
        {
            this.id = 184;
            name = n;
            marks = s;
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + marks);
            Console.ReadKey();
        }
    }
    class Testclass13
    {
        public static void Main(string[] args)
        {
            //Parameterised Constructor with 3 arguments.
            class13 e1 = new class13(101, "Sonoo", 890f);
            //Parameterised Constructor with 2 arguments.
            class13 e2 = new class13("Mahesh", 790f);
            //Default Constructor with no arguments.
            class13 e3 = new class13();
            e1.display();
            e2.display();
            e3.display();
        }
    }  
}
