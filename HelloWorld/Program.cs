internal class Program
{
    private static void Main(string[] args)
    {
        //1
        string name = "param";
        Console.WriteLine("welcome"+ name);

        //2
        Console.WriteLine(string.Format("welcome {0}",name));
        Console.WriteLine("welcome {0}",name);

        //3
        Console.WriteLine($"welcome{name}");
    }
}