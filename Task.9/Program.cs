using System;

namespace Task._9
{
    internal class Program
    {/* 9 reqemli ededdin tek yerde 
               dayananlardan bir eded duzlet: 132346389=12439 */
        static void Main(string[] args)
        {
            
            int a = 123456789;

            bool isSuccess = (a >= 100000000 && a < 1000000000);

            if (!isSuccess)

            {
                Console.WriteLine("9 regemli deyil");

                return;
            }

             int counter = 1;
             int remainder;
             int newNum = 0;

            while (a>0)
            {
                remainder = a % 10;
                
                a /= 10;
                

                if (counter % 2 != 0)

                {
                    newNum = newNum * 10 + remainder;
                }

                counter++;              
                
            }
            a = newNum;
            newNum = 0;

            while (a>0)
            {
                remainder = a % 10;
                a/=10;
                newNum = newNum * 10 + remainder;

            }
                 Console.WriteLine(newNum);      

            
            
        }
    }
}
