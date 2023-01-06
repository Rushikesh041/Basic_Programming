namespace Basic_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            int H = Convert.ToInt32(Console.ReadLine());
            double value =0;
            for (int i = 1; i <= H; i++)
            {
                value += 1 / (float)i;
            }
            Console.WriteLine("Sum of n Numbher of Hrmonic series is " + value);

        }
    }
}