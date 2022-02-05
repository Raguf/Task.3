using System;

namespace Task._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* verilmihs 4 reqemli ededin 
               tersine duzub axirina ve evveline 8 artir */

            int a = 1234;
            int b;
            
            bool isSuccess = (a >= 1000 && a < 10000);

            if (!isSuccess)
            {
                Console.WriteLine("4 regemli deyil");

                return;
            }

            int yenieded = 0;

            while (a > 0)
            {
                int qaliq = a % 10;
                a = a / 10;
                yenieded = yenieded * 10 + qaliq;
            }
               Console.WriteLine(yenieded);

            a = 80000 + yenieded;                        // 84321
            b = (a * 10) + 8;                            // 843218

            Console.WriteLine(a);
            Console.WriteLine(b);
            
           
        }
    }
}
