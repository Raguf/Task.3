using System;

namespace Task._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 9 reqemli ededdi tek yerde dayananlardan bir eded duzlet,
               sonra cut yerde dayanlarinda bir eded duzlet,
               sonra onlari topla*/

            int a = 123456789;
            int b = a;
            int sum;
            bool issuccess = (a >= 100000000 && a < 1000000000);

                if (!issuccess)
            {
                Console.WriteLine("not an 9 digit number");

                return;
            }

            int counter = 1;
            int remainder;
            int newNum = 0;

            while (a > 0)
            {
                remainder = a % 10;

                a /= 10;

                if (counter % 2 !=0)
                {
                    newNum = newNum * 10 + remainder;
                }
                counter++;
                
            }
                Console.WriteLine(newNum);

            while (newNum>0)

            {
                remainder= newNum % 10;
                newNum /= 10;
                a = a * 10 + remainder;
                               
            }
            Console.WriteLine(a);
            
            int counter1 = 0;
            int remainder1;
            int newNum1 = 0;           
                     
            while (b > 0)
            {
                remainder1 = b % 10;

                b /= 10;

                if (counter1 % 2 != 0)
                {
                    newNum1 = newNum1 * 10 + remainder1;
                }
                counter1++;

            }
            Console.WriteLine(newNum1);
      
            while (newNum1 > 0)

            {
                remainder1 = newNum1 % 10;
                newNum1 /= 10;
                b = b * 10 + remainder1;

            }
            Console.WriteLine(b);

            sum = a + b;
            Console.WriteLine(sum);

        }
    }
}
