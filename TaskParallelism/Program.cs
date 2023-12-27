using System.ComponentModel;

namespace TaskParallelism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task task1 = Task.Run(() => DoWork("Task 1"));
            Task task2 = Task.Run(() => DoWork("Task 1"));
            Task task3 = Task.Run(() => DoWork("Task 1"));

            Task.WaitAll(task1,task2,task3);

            Console.WriteLine("All tasks completed");
            Console.ReadLine();
        }
        static void DoWork(string taskName)
        {
            Console.WriteLine($"Working on {taskName}on thread{Task.CurrentId}");

        }
    }
}


        
    
