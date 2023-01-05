namespace Basic_Programming
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Dividend : ");
            int Dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor : ");
            int Divisor = Convert.ToInt32(Console.ReadLine());

            int Quotient = Dividend / Divisor;
            int Remainder = Dividend % Divisor;

            Console.WriteLine("Quotient is : " + Quotient);
            Console.WriteLine("Remainder is : " + Remainder);
        }
    }
}