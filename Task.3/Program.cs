using System;

namespace Task._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* verilmihs 9 reqemli ededin 
               duz ortaya dushen 3 reqeminin reqemleri cemi*/

            int a = 123456789;
            int cem = 0;
            int b;
            int c;
            int d;
            int e;
     
            if (a >= 100000000 && a < 1000000000) 

            {
                int qaliq = a % 1000;               // 789
                b = (a - qaliq) / 1000;             // 123456

                Console.WriteLine(qaliq);
                Console.WriteLine(b);

                qaliq = b % 10;                     // 6
                c = (b - qaliq) / 10;               // 12345
                cem = cem + qaliq;                  // 6

                Console.WriteLine(qaliq);
                Console.WriteLine(c);
                Console.WriteLine(cem);

                qaliq = c % 10;                     // 5
                d = (c - qaliq) / 10;               // 1234
                cem = cem + qaliq;                  // 11

                Console.WriteLine(qaliq);
                Console.WriteLine(d);
                Console.WriteLine(cem);

                qaliq = d % 10;                     // 4
                e = (d - qaliq) / 10;               // 123
                cem = cem + qaliq;                  // 15

                Console.WriteLine(qaliq);
                Console.WriteLine(e);
                Console.WriteLine(cem);
            }

            else

            {
                Console.WriteLine("9 regemli deyil");
            }



        }
    }
}
