namespace MultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Thread id{Thread.CurrentThread.ManagedThreadId}");
            Thread childThread = new Thread(new ThreadStart(Method1));
            childThread.Start(); 
           // Thread.CurrentThread.UnsafeStart();
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            for(int index=0;index<numbers.Count; index++)
            {

            }
            Parallel.For(0, numbers.Count, num =>
            {
                Console.WriteLine(num);
            });

            foreach(var item in numbers)
            {

            }


        }

        static void Method1()
        {
            Thread.Sleep(5000);
            Console.WriteLine($"Thread id {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}