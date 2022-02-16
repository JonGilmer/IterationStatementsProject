using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();

            int num = 0;

            do
            {
                num++;
                numbers.Add(num);

            } while (num < 100);


            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }


            Console.WriteLine("Increase:");

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            for (int i = 199; i <= numbers.Count && i >= 0; i--)

            {
                Console.WriteLine(numbers[i]);// place numbers[i] inside of the Console.WriteLine() method
            }

            //------------End of exercise

            //------------for loops 15 times

            //1.
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //2.
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //3.
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //4.
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //5.
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //6.
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //7.
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //8.
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //9.
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //10.
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //11.
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //12.
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //13.
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //14.
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}

            //15.
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"{i}");
            //}
        }
    }
}
