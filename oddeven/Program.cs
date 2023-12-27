namespace oddeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Even Numbers:");
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine("\nOdd Numbers:");
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.ReadLine(); //to prevent console window to close immediately
        }
    }
}