using System;

namespace Task._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* verilmihs 8 reqemli ededin 
               ilk I ve axirinci reqemlerini legv et*/

            int a = 12345678;
            int b;
            int c;

            if (a>=10000000 && a<100000000)

            {
                b = a - 10000000;           // 2345678
                int qaliq = b % 10;         // 8
                c = (b - qaliq) / 10;       // 234567

                Console.WriteLine(b);
                Console.WriteLine(qaliq);
                Console.WriteLine(c);
            }

            else
            {
                Console.WriteLine("8 regemli deyil");
            }
        }
    }
}
