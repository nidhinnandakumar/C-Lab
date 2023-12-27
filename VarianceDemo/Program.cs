namespace VarianceDemo
{
    internal class Program
    {
        public delegate Small Delegate1(Big big);
        static void Main(string[] args)
        {
            /*Small obj=new Small();
            Small obj1=new Big();
            Small obj2=new Bigger();
            Big obj3=new Bigger();
            //Big obj4=new Small();*/// not allowed as base type csn point to derived and base type but a derived type canot point to base type

            Delegate1 del1 = new Delegate1(Method1);
            Delegate1 del2 = Method2;
            Small s = del1(new Big());
            Small s1=del2(new Bigger());
           // Small s2 = del1(new Small());

            Delegate1 del3 = method3;
            Small s3=del3(new Small());
            Small s4=del3(new Big());   

        }
        public static Big Method1(Big big)
        {
            Console.WriteLine("Method1");
            return new Big();
        }
        public static Small Method2(Big big)
        {
            Console.WriteLine("Method2");
            return new Small();
        }
        public static Small method3(Small small)
        {
            Console.WriteLine("Method3");
            return new Small(); 
        }
    }
    public class Small
    {

    }
    public class Big : Small
    {

    }
    public class Bigger : Big
    {

    }
}