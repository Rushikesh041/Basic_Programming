namespace Basic_Programming
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Times = 100;
            float count1 = 0;
            float count2 = 0;
            for (int i = 1; i <= Times; i++)
            {
                Random random = new Random();
                int Flip = random.Next(0, 2);

                if (Flip == 0)
                {
                    Console.WriteLine("HEAD");
                    count1++;
                }
                else if (Flip == 1)
                {
                    Console.WriteLine("TAILS");
                    count2++;
                }
          
            }
            double Percentage = (count1 / count2) * 100;
            Console.WriteLine("Percentage of Head vs Tail is : " + (Math.Round(Percentage, 2)));
        }
    }
}