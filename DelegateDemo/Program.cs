namespace DelegateDemo
{
    //1
    public delegate void MathDelegate(int num1, int num2);
    

    internal class program 
    {

   
        static void Main(string[] args)
        {
            //3
            MathDelegate mathDel = Add;
            //MathDelegate mathAdd = new MathDelegate(mathDel);

            //4 invoke
            mathDel += Subtract;
            mathDel += Multiply;
            mathDel += Divide;

            mathDel(2, 3);

        }
        //2 define the method to which delegate points to
        public static void Add(int num1,int num2) 
        {
            Console.WriteLine("Sum");
            Console.WriteLine(num1+num2);
        }

        public static void Subtract(int num1, int num2)
        {
            Console.WriteLine("subtraction");
            Console.WriteLine(num1 - num2);
        }

        public static void Multiply(int num1, int num2)
        {
            Console.WriteLine("Multiplication");
            Console.WriteLine(num1 * num2);
        }

        public static void Divide(int num1, int num2)
        {
            Console.WriteLine("Division");
            Console.WriteLine(num1 / num2);
        }




    }
}