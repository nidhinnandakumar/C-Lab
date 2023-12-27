using System.Reflection;

namespace OptionalAndNamedParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddBook(isbn: "abc", price: 100, title: "abc", author: "xyz");
            AddBook("abc", "hdjkahakj", "bhu");
            AddBook("abc", "hdjkahakj", "bhu",200);

        }
        static bool AddBook(string title,string isbn="123",string author,decimal price=100)
        {
            return true;
        }
    }
}