namespace FileSystemWatcherDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher("C:\\Users\\nidhin.nandakumar\\Desktop\\LABS\\CSharpLabs1\\Demos");
            watcher.EnableRaisingEvents = true;

            watcher.Created += Watcher_change;
            watcher.Deleted += Watcher_change;
            watcher.Changed += Watcher_change;
            Console.ReadLine();
            

        }

        private static void Watcher_change(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"{e.Name}, change: {e.ChangeType}");
        }
    }
}