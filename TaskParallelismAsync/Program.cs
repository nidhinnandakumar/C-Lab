namespace TaskParallelismAsync
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Task<int> task1 = Task.Run(() => DoAsyncWork("Task 1"));
            Task<int> task2 = Task.Run(() => DoAsyncWork("Task 2"));
            Task<int> task3 = Task.Run(() => DoAsyncWork("Task 3"));

            int[] results = await Task.WhenAll(task1, task2, task3);
            Console.WriteLine($"Results:{string.Join(",", results)}");
        }
        static async Task<int> DoAsyncWork(string taskName)
        {
            Console.WriteLine($"working on {taskName} asynchronously on thread");

            await Task.Delay(2000);
            return taskName.Length;
        }
    }
}
