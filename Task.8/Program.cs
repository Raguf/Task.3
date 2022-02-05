using System;

namespace Task._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Verilmis ededdin axirdan 3-cu reqemi 
               ile sonuncu reqeminin cemini tap  */

            int a = 123456;
            int b;
            int c;
            int d;
            int e;
            int cem = 0;

            if (a >= 100000 && a < 1000000)

            {
                int qaliq = a % 10;                    // 6
                b = (a - qaliq) / 10;                  // 12345
                cem = cem + qaliq;                     // 6
                 
                Console.WriteLine(qaliq);
                Console.WriteLine(b);
                Console.WriteLine(cem);

                qaliq = a % 100;                       // 56
                c = (a - qaliq) / 100;                 // 1234

                Console.WriteLine(qaliq);
                Console.WriteLine(c);

                qaliq = c % 10;                        // 4
                d = (c - qaliq) / 10;                  // 123
                cem = cem + qaliq;                     // 10

                Console.WriteLine(qaliq);
                Console.WriteLine(d);
                Console.WriteLine(cem);

            }

            else
            {
                Console.WriteLine("6 regemli deyil");
            }
        }
    }
}
