namespace Basic_Programming
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To Find Largest Number Enter Three Numbers Below");
            Console.WriteLine("Enter Number 1 : ");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 : ");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 3 : ");
            int Num3 = Convert.ToInt32(Console.ReadLine());
            if (Num1 > Num2 && Num1 > Num3)
            {
                Console.WriteLine(Num1 + " is Largest Amoung All");
            }
            else if (Num2 > Num1 && Num2 > Num3)
            {
                Console.WriteLine(Num2 + " is Largest Amoung All");
            }
            else
            {
                Console.WriteLine(Num3 + " is Largest Amoung All");
            }
        }
    }
}