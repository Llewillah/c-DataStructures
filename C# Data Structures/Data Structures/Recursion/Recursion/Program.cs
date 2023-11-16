using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static void printNumbers(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(" n = {0} ", n);
                printNumbers(n - 1);
            }
            Console.WriteLine("\n Recursion Unfolding  --- n = {0} ", n);
        }

        static void range(int start, int stop)
        /* Displays numbers between start and stop - start <= stop */
        {
            if (start == stop)
            {
                Console.Write("{0}", start);
            }
            else
            {
                /* recursive call and print start*/
                Console.Write("{0},", start);
                range(start + 1, stop);
            }
        }

        static string getNumberString(int n)
        {
            if (n == 0)
                return "";
            else
            {
                string x = n + getNumberString(n - 1);
                return x;
            }
        }

        static int multiply(int x, int y)
        {
            if (y == 1)
                return x;
            else
            {
                int n = x + multiply(x, dec(y));
                return n;
            }
        }

        static int power(int x, int y) 
        {
            if (y == 1)
            {
                return x;
            }
            else 
            {
                int n = x * power(x, dec(y));
                return n;
            }

        }
        static int count = 0;
        static void permutations(int[] numbers) 
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                    Console.Write(numbers[i]);
            }

            if (count = )
            permutations(numbers);

        }

        static int inc(int x)
        {
            return x + 1;
        }

        static int dec(int x)
        {
            return x - 1;
        }


        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            permutations(numbers);
            Console.ReadKey();
        }

    }
}
