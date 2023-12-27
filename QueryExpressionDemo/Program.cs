namespace QueryExpressionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, };
            //1 foreach

            
            List<int> evennumbers = numbers.FindAll(n=>n%2==0);//lambda expression

            //3 query expression
            //3.1 query syntax
            var evenNum = from n in numbers
                          where n % 2 == 0
                          select n;

           /* foreach (var n in evennumbers)
            {
                Console.WriteLine(n);
            } */

            //3.2 Method/lambda syntax
            var evenNum2 = numbers.Where(n => n % 2 == 0);
        }
    }
}