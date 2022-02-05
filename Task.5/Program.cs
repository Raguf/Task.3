using System;

namespace Task._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* verilmihs 6 reqemli ededin 
               1 ci reqemini hemin ededin axirina at.*/

            int a = 123456;
            int b;
            int c;
            int d;
            int e;

            if (a>=100000 && a<1000000)

            {
                int qaliq = a % 100000;    // 23456
                b = (a - qaliq) / 100000;  // 1

                Console.WriteLine(qaliq); 
                Console.WriteLine(b);     

                c = a - 100000;           // 23456
                d = c * 10;               // 234560
                e = d + b;                // 234561
                
                Console.WriteLine(c);
                Console.WriteLine(d);
                Console.WriteLine(e);
            }

            else 

            {
                Console.WriteLine("6 regemli deyil");
            }

        }
    }
}
