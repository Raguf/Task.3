using System;

namespace Task._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* verilmihs 6 reqemli ededin 
             * ilk 3 denesinin reqemleri cemi tap
             */

            int a = 123456;
            int cem = 0;
            int b;
            int c;
            int d;
            int e;
                     
            if (a >= 100000 && a < 1000000) 
            {
                int qaliq = a % 1000;      // 456
                b = (a - qaliq) / 1000;    // 123

                Console.WriteLine(qaliq);
                Console.WriteLine(b);

                qaliq = b % 10;            // 3
                c = (b - qaliq) / 10;      // 12
                cem = cem + qaliq;         // 3

                Console.WriteLine(qaliq);
                Console.WriteLine(c);
                Console.WriteLine(cem);

                qaliq = c % 10;            // 2
                d = (c - qaliq) / 10;      // 1
                cem = cem + qaliq;         // 5

                Console.WriteLine(qaliq);
                Console.WriteLine(d);
                Console.WriteLine(cem);

                qaliq = d % 10;            // 1
                e = (d - qaliq) / 10;      // 0
                cem = cem + qaliq;         // 6

                Console.WriteLine(qaliq);
                Console.WriteLine(e);
                Console.WriteLine(cem);
            }

            else 

            {
                Console.WriteLine("6 regemli deyil");
            }
        }
    }
}
