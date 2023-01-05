namespace Basic_Programming
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year to Check Whether Leap Year or Not : ");
            int Year =Convert.ToInt32(Console.ReadLine());
            if (Year % 4 == 0)
            {
                if (Year % 100 == 0)
                {
                    if (Year % 400 == 0)
                    {
                        Console.WriteLine("Its a Leap Year");
                    }
                    else
                    {
                        Console.WriteLine("Its not a Leap Year");

                    }
                }
                else
                {
                    Console.WriteLine("Its a Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Its not a Leap Year");
            }
        }
    }
}