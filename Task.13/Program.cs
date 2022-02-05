using System;

namespace Task._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3 dene 5 reqemli eded var.
             Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. 
             Alinan neticeleri topla
             Yekunda alian cavabin 50%-ni hemin ededin uzerine gel.*/

            int a = 12345;
            int b = 23456;
            int c = 34567;
            int remainder;
            int newNum = 0;
            int d;
            int e;
            int f;
            int g;  
            int h;
            int pers;
            int sum = 0;

            bool issuccess = (a >= 10000 && a <= 100000 &&
                          b >= 10000 && b <= 100000 &&
                          c >= 10000 && c <= 100000);

            if (!issuccess)
            {
                Console.WriteLine("not an 5 digit number");

                return;
            }

            if (a>0)

            {
                remainder = a % 10000;             // 2345
                d = (a - remainder) / 10000;       // 1

                Console.WriteLine(remainder);
                Console.WriteLine(d);

                remainder = a % 10;                // 5
                e = (a - remainder) / 10;          // 1234
                f = newNum + remainder;            // 5
                g = (d * 10) + f;                  // 15
                sum = sum + g;

                Console.WriteLine(remainder);
                Console.WriteLine(e);
                Console.WriteLine(f);
                Console.WriteLine(g);
                Console.WriteLine(sum);
            }

            if (b > 0)

            {
                remainder = b % 10000;             // 3456
                d = (b - remainder) / 10000;       // 2

                Console.WriteLine(remainder);
                Console.WriteLine(d);

                remainder = b % 10;                // 6
                e = (b - remainder) / 10;          // 3456
                f = newNum + remainder;            // 6
                g = (d * 10) + f;                  // 26
                sum = sum + g;

                Console.WriteLine(remainder);
                Console.WriteLine(e);
                Console.WriteLine(f);
                Console.WriteLine(g);
                Console.WriteLine(sum);
            }

            if (c > 0)

            {
                remainder = c % 10000;             // 4567
                d = (c - remainder) / 10000;       // 3

                Console.WriteLine(remainder);
                Console.WriteLine(d);

                remainder = c % 10;                // 7
                e = (c - remainder) / 10;          // 4567
                f = newNum + remainder;            // 7
                g = (d * 10) + f;                  // 37
                sum = sum + g;

                Console.WriteLine(remainder);
                Console.WriteLine(e);
                Console.WriteLine(f);
                Console.WriteLine(g);
                Console.WriteLine(sum);            // 15+26+37=78
            }
            
                pers = (sum * 50) / 100;           // 39
                h = sum + pers;                    // 117

            Console.WriteLine(pers);
               Console.WriteLine(h);
        }
    }
}
