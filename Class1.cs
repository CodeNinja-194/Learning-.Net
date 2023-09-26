using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
public class Class1
{
    public static void main()
    {
        int n = 0, sum = 0;
        Console.WriteLine("Enter a number");
        n = Convert.ToInt32(Console.ReadLine());
        int q = n;
        int rem;
        while (q != 0)
        {
            rem = q % 10;
            int fact = Cal(rem);
            q = q / 10;
            sum = sum + fact;
        }
        if (sum == n)
        {
            Console.WriteLine(n + " is a Strong Number");
        }
        else
        {
            Console.WriteLine(n + " is not a Strong Number");
        }
        Console.ReadKey();
    }
    // Factorial
    public static int Cal(int n)
    {
        int f = 1;
        for (int i = 1; i <= n; i++)
        {
            f = f * i;
        }
        return f;
    }
}