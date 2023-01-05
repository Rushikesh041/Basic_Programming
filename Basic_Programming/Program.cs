namespace Basic_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number to Check Even or Odd :");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number % 2 == 0)
            {
                Console.WriteLine(Number + " is an Even Number ");
            }
            else
            {
                Console.WriteLine(Number + " is an Odd Number ");
            }
        }
    }
}