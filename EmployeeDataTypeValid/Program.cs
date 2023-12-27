using System.Text.RegularExpressions;

namespace EmployeeDataTypeValid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee id");
            string input=Console.ReadLine();
            if (!int.TryParse(input,out int id)|| id<=0)
            { 
                Console.WriteLine("invalid input");
                return;
            }
            Employee emp = new Employee();
            emp.Id = id;

            Console.WriteLine("Enter Name");
            input = Console.ReadLine();
            if(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid Name");
                return;
            }
            emp.Name = input;

            Console.WriteLine("Enter the Birth Date");
            input=Console.ReadLine();
            if (!DateTime.TryParse(input,out DateTime birthdate))
            {
                Console.WriteLine("invalid date");
                return;
            }
            emp.BirthDate = birthdate;


            Console.WriteLine("Enter the Email");
            input = Console.ReadLine();
            if (!Regex.IsMatch(input, "@\"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,4}$\";"))
            {
                Console.WriteLine("Invalid Email");
            }
            emp.Email = input;

            Console.WriteLine("program is finished ! Thnak you visit again");

        }
    }
}