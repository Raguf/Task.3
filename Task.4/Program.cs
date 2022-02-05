using System;

namespace Task._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* verilmihs 5 reqemli ilk ve 
               son reqemlerinin ceminin kvadrati*/

            int a = 12345;
            int cem = 0;
            int hasil = 1;
            int b;
            int c;

            if (a>=10000 && a<100000)

            {
                int qaliq = a % 10000;                        // 2345
                b = (a - qaliq) / 10000;                      // 1

                Console.WriteLine(qaliq);
                Console.WriteLine(b);

                qaliq = a % 10;                               // 5
                c = (a - qaliq) / 10;                         // 1234
                cem = cem + b + qaliq;                        // 6
                hasil = hasil * (b + qaliq) * (b + qaliq);    // 36

                Console.WriteLine(qaliq);
                Console.WriteLine(c);
                Console.WriteLine(cem);
                Console.WriteLine(hasil);                
            }

            else 

            {
                Console.WriteLine("5 regemli deyil");
            }
        }
    }
}
