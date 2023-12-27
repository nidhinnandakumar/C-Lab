namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> recipes= new List<string>();
            Console.WriteLine(recipes.Capacity);
            recipes.Add("pasta");
            recipes.Add("pizza");
            recipes.Add("Burger");
            recipes.Add("Steak");
            recipes.Add("Noodles");
            Console.WriteLine(recipes.Capacity);
            recipes.Add("pasta");
            recipes.Add("pizza");
            recipes.Add("Burger");
            recipes.Add("Steak");
            recipes.Add("Noodles");
            Console.WriteLine(recipes.Capacity);

            recipes.Clear();
            Console.WriteLine(recipes.Capacity);

            List<int> numbers = new List<int>
            {
                1,
                2,
            };








        }
    }
}