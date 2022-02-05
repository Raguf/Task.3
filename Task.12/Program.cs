using System;

namespace Task._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 2 dene 5 reqemli eded daxil et.
               I ededin reqemleri ceminin usutne
               II ededin reqemleri hasilini gel.
               Neticenin axirina I ededin en axiinci reqemini artir.*/

            int a = 12345;
            int b = 23456;
            int c;
            int d;
            int remainder;
            int sum = 0;
            int mult = 1;
            bool issucces = (a >= 10000 && a <= 100000 
                          && b >= 10000 && b <= 100000);

            if (!issucces)
            {
                Console.WriteLine("Wrong numbers");
            }

            while (a > 0)
            {
                remainder = a % 10;
                a=(a-remainder)/10;
                sum = sum + remainder;
            }
            Console.WriteLine(sum);               // 15

            while (b > 0)
            {
                remainder = b % 10;
                b = (b - remainder) / 10;
                mult = mult * remainder;
            }
            Console.WriteLine(mult);             // 720

            c = sum + mult;                      // 735
            d = (c * 10) + 5;                    // 7355 
            Console.WriteLine(d);
        }
    }
}
