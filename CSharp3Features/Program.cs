namespace CSharp3Features
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var i = 10;
            //i = "abc";
            // var message;
            //method1(10);
            var product = new
            {
                Id = 0,
                Name = "headphone",
                Price = 10
            };
            String number = "123";
            int num = number.ToNumber();

            Customer customer1 = new Customer(1);
            //customer1.CustomerId = 1;
            customer1.Name = "John Snow";
            customer1.City = "Westeros";

            Customer customer2 = new Customer(2)
            {
               // CustomerId = 2,
                Name = "Arya Stark",
                City = "westeros"
            };

            //static method1(var num)
           // {
           // }

            var customerlist = new List<Customer>
            {
                customer1,
                customer2,
                new Customer(3)
                {
                    Name="Tyrion",
                    City="Westeros"
                }
            };

        }
    }
}