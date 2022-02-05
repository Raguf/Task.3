using System;

namespace Task._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*verilmish 4 reqemli ededin reqemlerinin cemini tap*/

            int a = 1234;
            int cem = 0;
            
            if (a>=1000 && a<10000)

            {
                int qaliq = a % 10;   // 4
                a = (a - qaliq) / 10; // 123
                cem = cem + qaliq;    // 4

                Console.WriteLine(qaliq);
                Console.WriteLine(a);
                Console.WriteLine(cem);

                qaliq = a % 10;       // 3
                a = (a - qaliq) / 10; // 12
                cem = cem + qaliq;    // 7

                Console.WriteLine(qaliq);
                Console.WriteLine(a);
                Console.WriteLine(cem);

                qaliq = a % 10;       // 2
                a = (a - qaliq) / 10; // 1
                cem = cem + qaliq;    // 9

                Console.WriteLine(qaliq);
                Console.WriteLine(a);
                Console.WriteLine(cem);

                qaliq = a % 10;       // 1
                a = (a - qaliq) / 10; // 0
                cem = cem + qaliq;    // 10

                Console.WriteLine(qaliq);
                Console.WriteLine(a);
                Console.WriteLine(cem);
            }

            else

            {
                Console.WriteLine("4 regemli deyil");
            }
        }
    }
}
