using System;

namespace Task._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
             * 6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
             * Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
               Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
               Neticenin 60 % tap. Cavabin axirina 60 artir.
               Neticeden 18% cix.*/

            int a = 123456;
            int b = 234567;
            int c = 345678;
            int d = 4567890;
            int e;
            int g;
            int f;
            int remainder;
            int sum;
            int newNum = 0;
            int mult = 1;
            int pers;
            int newPers;
            int addNum;
            int total;
            
            bool issucces = (a >= 100000 && a < 1000000 &&
                         b >= 100000 && b < 1000000 &&
                         c >= 100000 && c < 1000000 &&
                         d >= 1000000 && d < 10000000);

            if (!issucces)
            {
                Console.WriteLine("Wrong numbers");

                return;
            }

            if (a>0)
            {
                remainder = a % 1000;            // 456
                a = (a - remainder) / 1000;      // 123
                
                Console.WriteLine(remainder);
                Console.WriteLine(a);               
            }

            if (b > 0)
            {
                remainder = b % 1000;            // 567
                b = (b - remainder) / 1000;      // 234

                Console.WriteLine(remainder);
                Console.WriteLine(b);
            }

            if (c > 0)
            {
                remainder = c % 1000;            // 678
                c = (c - remainder) / 1000;      // 345

                Console.WriteLine(remainder);
                Console.WriteLine(c);
            }
                 sum = a + b + c;                // 702

                Console.WriteLine(sum);

            if (d>0)
            {
                remainder = d % 10000;            // 7890
                d = (d - remainder) / 10000;      // 456

                e = newNum + remainder;           // 7890
                f = sum + e;                      // 8592

                Console.WriteLine(remainder);
                Console.WriteLine(d);
                Console.WriteLine(e);
                Console.WriteLine(f);

                remainder = d % 10;
                d = (d - remainder) / 10;
                mult = mult * remainder;

                Console.WriteLine(mult);            // 4

                remainder = d % 10;
                d = (d - remainder) / 10;
                mult = mult * remainder;           // 30

                Console.WriteLine(mult);

                remainder = d % 10;
                d = (d - remainder) / 10;
                mult = mult * remainder;

                Console.WriteLine(mult);           // 120
                
                   g = f - mult;                   // 8472

                Console.WriteLine(g);

                pers = (g * 60) / 100;             // 5083

                Console.WriteLine(pers);

                addNum = (5083 * 100) + 60;        // 508360

                Console.WriteLine(addNum);

                newPers = (addNum * 18) / 100;     // 91504

                Console.WriteLine(newPers);

                total = addNum - newPers;          // 416856

                Console.WriteLine(total);
            }

            
                
            
                 
            
            
        }
        
    }
}
