using System;

namespace Task._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli . 1 denesi 7 reqemli olsun.
                3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.
                Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
                Cavabdan 7 reqemli ededin son 5 reqemini cix.
                Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
                Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
                Cavabin axirina 11 artir.
                Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
                Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.*/

            int a = 123;
            int b = 234;
            int c = 345678;
            int d = 456789;
            int e = 5678901;
            int fifNum = e;
            int f;
            int g;
            int h;
            int i;
            int k;
            int j;
            int sqNum;
            int addNum;
            int newNum = 0;
            int secNum = 0;
            int thNum = 0;
            int frNum = 0;
            int sixNum = 0;
            int remainder;
            int sum = 0;
            int counter = 1;

            bool issucces = (a >= 100 && a < 1000 &&
                         b >= 100 && b < 1000 &&
                         c >= 100000 && c < 1000000 &&
                         d >= 100000 && d < 1000000 &&
                         e >= 1000000 && e < 10000000);

            if (!issucces)
            {
                Console.WriteLine("Wrong numbers");

                return;
            }

            if (a>0 && b>0)

            {
                f = a + b;                    // 357

                Console.WriteLine(f);

                remainder = f % 100;          // 57
                f = (f - remainder) / 100;    // 3
                newNum = newNum + remainder;  // 57
                sqNum = newNum * newNum;      // 3249
                addNum = (a * 1000) + b;      // 123234
                sum = sqNum + addNum;         // 126483

                Console.WriteLine(remainder);
                Console.WriteLine(f);
                Console.WriteLine(newNum);
                Console.WriteLine(sqNum);
                Console.WriteLine(addNum);
                Console.WriteLine(sum);                           
            }
                if (e > 0)
            {
                remainder = e % 100000;         // 78901
                e = (e - remainder) / 100000;   // 56
                secNum = secNum + remainder;    // 78901
                g = sum - secNum;               // 47582

                Console.WriteLine(remainder);
                Console.WriteLine(e);
                Console.WriteLine(secNum);
                Console.WriteLine(g);                
                       
                h = c + d;                     // 802467

                Console.WriteLine(h);

                remainder = h % 1000;         // 467
                h = (h - remainder) / 1000;   // 802
                thNum = thNum + remainder;    // 467
                i = g + thNum;                // 48049
                 
                Console.WriteLine(remainder);
                Console.WriteLine(h);
                Console.WriteLine(thNum);
                Console.WriteLine(i);
            }
            
            while (fifNum>0)
            {
                remainder = fifNum % 10;  
                fifNum = (fifNum - remainder) / 10;
                frNum = frNum + remainder;

                Console.WriteLine(remainder);
                Console.WriteLine(fifNum);
                Console.WriteLine(frNum);    // 36
            }
            
                r
            
            
            
        }
    }
}
