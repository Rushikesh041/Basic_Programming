namespace Basic_Programming
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1 : ");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 : ");
            int Number2 = Convert.ToInt32(Console.ReadLine());

            int Number3 = Number1;
                Number1 = Number2;
                Number2 = Number3;

            Console.WriteLine("Number 1 is : " + Number1);
            Console.WriteLine("Number 2 is : " + Number2);
        }
    }
}