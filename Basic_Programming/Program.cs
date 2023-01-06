using System;

namespace Basic_Programming
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Index of 2 : ");
            int N = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            int b = 0;
            int num;
            for (int i = 0; i < N; i++)
            {
                if (N >= 31)
                {
                    Console.WriteLine("Value is ouf of Int Limit");
                    break;
                }
                num = (2 * a);
                a = num;
                b++;
                Console.WriteLine("2 to the Power of " + b + " is : " + num);
            }
        }
    }
}