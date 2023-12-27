namespace MethodParamsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object obj = 10;
            obj = "abc";

            var val = 10;
            val = "abc";

            dynamic obj2 = 10;
            obj2="abc";


            int number = 20;
            method1(ref number);
            Console.WriteLine(number);

            int num2;
            method3(1, 2, 3, 4);
            method4(new int[] { 1, 2, 3 });

        }
        static void method1(ref int num)
        {
            num = num + 10;
        }
        static void method2(out int num) 
        {
            num = 10;
        }
        static void method3(params int[] numbers)
        {

        }
        static void method4(int[] numbers)
        {

        }
    }
}