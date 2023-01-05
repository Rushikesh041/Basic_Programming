namespace Basic_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Alphabet to Check Vowel or Consonant : ");
            char Alphabet = Convert.ToChar(Console.ReadLine().ToLower());
            if (Alphabet == 'a' || Alphabet == 'e' || Alphabet == 'i' || Alphabet == 'o' || Alphabet == 'u')
            {
                Console.WriteLine(Alphabet + " is Vowel.");
            }
            else
            {
                Console.WriteLine(Alphabet + " is Consonent.");
            }
        }
    }
}