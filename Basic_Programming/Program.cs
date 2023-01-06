using System.Numerics;

namespace Basic_Programming
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number For Prime Factor : ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int Factor;
            for (Factor = 2; Number>1; Factor++)
            {
                if (Number % Factor == 0) 
                {
                    int Times = 0;
                    while (Number % Factor == 0)
                    {
                        Number = Number / Factor;
                        Times++;
                    }
                    Console.WriteLine(Factor + " is Prime Factor " + Times + " times ");
                }
            }
        }
    }
}