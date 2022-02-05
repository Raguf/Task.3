using System;

namespace Task._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 8 reqemli ededin reqemlerini iki -iki qruplashdir.
               Qruplarin cemini tap. Alinan cavabin axirina 99 artir.
               Sonra cavabin ozunden onun 18% ni cix;*/

            int a = 12345678;
            int b;
            int c;
            int d;
            int e;
            int remainder;
            int sum = 0;
            bool issuccess = (a >= 10000000 && a <= 100000000);

            if (!issuccess)
            {
                Console.WriteLine("not an 8 digit number");
                return;
            }

            while (a>0)
            {
                remainder = a % 100;
                a = (a - remainder)/100;
                sum = sum + remainder;
            }
               Console.WriteLine(sum);       // 180

            b = sum * 100;                  // 18000 
            c = b + 99;                     // 18099
            d = (c * 18) / 100;             // 3257
            e = b - d;                      // 14743


            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
        }
    }
}
