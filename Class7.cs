using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class7
    {
            public static  void main(string[] args)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int res = Add(a, b);
                Console.WriteLine(res);
                int res2 = Add(a, b, 10);
                Console.WriteLine(res2);
                Console.ReadKey();
            }
            public static int Add(int x,int y,int z)
            {
                    return x+y+z;
            }
            public static int Add(int a,int b)
            {
                return a+b;
            }
    
    }
}
