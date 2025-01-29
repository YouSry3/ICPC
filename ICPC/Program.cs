using System;
using System.Numerics;

namespace Codeforces
{
    internal class Program
    {
        static long AllNumbers(int num1,int num2)
        {
            long sum = 0;

            for (int i = num2; i <= num1; i++)
            {
               sum += i;
            }
            return sum;
        }
        static long EevenNumbers(int num1,int num2)
        {
            long sum = 0;

            for (int i = num2; i <= num1; i++)
            {
                if (i %2  == 0)
                {
                    sum += i;
                }
            }
            return sum;

        }
        static long OODNumbers(int num1, int num2 )
        {
            long sum = 0;

            for (int i = num2; i <= num1; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                }
            }
            return sum;
        }

        static void Main()
        {
            string[] numbers = Console.ReadLine().Split(" ");

            int Num1 = int.Parse(numbers[0]);
            int Num2 = int.Parse(numbers[1]);
            if (Num1 > Num2)
            {

                Console.WriteLine(AllNumbers(Num1, Num2));
                Console.WriteLine(EevenNumbers(Num1, Num2)) ;
                Console.WriteLine(OODNumbers(Num1, Num2));
            }
            else
            {
                Console.WriteLine(AllNumbers(Num2, Num1));
                Console.WriteLine(EevenNumbers(Num2, Num1));
                Console.WriteLine(OODNumbers(Num2, Num1));
            }



        }
    }
}
