using System.Linq.Expressions;

namespace ParameterExp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConstantExpression constant=Expression.Constant(5);
            ParameterExpression param =Expression.Parameter(type: typeof(int),"x");
            BinaryExpression addExpression=Expression.Add(param,constant); //arithmetic addition expression 
            Expression<Func<int,int>>lambda=Expression.Lambda<Func<int,int>>(addExpression, param);
            
            Func<int,int>addFunction=lambda.Compile();
            int result = addFunction(3);
            Console.WriteLine(result);

        }
    }
}