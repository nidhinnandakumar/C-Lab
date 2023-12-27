namespace ShapeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 Circle,2 Rectangle ,3 Triangle ,4 Trapezium,5 Square,6 Exit");
                Console.WriteLine("Select Shape");
                string input=Console.ReadLine();
                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("invalid input");
                    continue;
                }
                switch(choice)
                {
                    case 1: HandleCircle();  //circle
                        break;
                    case 2: HandleRectangle();//rectangle
                        break;
                    case 3: HandleTriangle(); //Triangle
                        break;
                    case 4:HandleTrapezium(); //Trapezium
                        break;
                    case 5:
                        Square(); //Square
                        break;

                    case 6:
                        Console.WriteLine("Thank you visit Again");
                        Environment.Exit(0); //exit
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;
                }
                
            }
           
        }

        // handle circle
        static void HandleCircle()
        {
            Console.WriteLine("Enter Radius");
            string input = Console.ReadLine();
            if (!double.TryParse(input, out double radius))
            {
                Console.WriteLine("invalid radius");
            }
            Circle circle1 = new Circle(radius);
            double area = circle1.Area();
            Console.WriteLine($"Area of circle : {area}");
        }

        //handle rectangle
        static void HandleRectangle()
        {
            Console.WriteLine("Enter length");
            string input = Console.ReadLine();
         if (!double.TryParse(input, out double l))
            {
                Console.WriteLine("invalid");
            }

            Console.WriteLine("enter breadth");
            string input2 = Console.ReadLine();
            if (!double.TryParse(input2, out double b))
            {
                Console.WriteLine("invalid");
            }

            Rectangle rectangle1 = new Rectangle(l, b);
            double area = rectangle1.Area();
            Console.WriteLine($"Rectangle Area : {area}");
        }

        static void HandleTriangle()
        {
            Console.WriteLine("Enter breadth");
            string input = Console.ReadLine();
            if (!double.TryParse(input, out double b))
            {
                Console.WriteLine("invalid");
            }

            Console.WriteLine("enter height");
            string input2 = Console.ReadLine();
            if (!double.TryParse(input2, out double h))
            {
                Console.WriteLine("invalid");
            }

            Triangle triangle = new Triangle(b, h);
            double area = triangle.Area();
            Console.WriteLine($"Triangle Area : {area}");
        }

        static void HandleTrapezium()
        {
            Console.WriteLine("Enter the side 1");
            string input = Console.ReadLine();
            if (!double.TryParse(input, out double a))
            {
                Console.WriteLine("invalid");
            }

            Console.WriteLine("enter the side 2");
            string input2 = Console.ReadLine();
            if (!double.TryParse(input2, out double b))
            {
                Console.WriteLine("invalid");
            }

            Console.WriteLine("enter the side 3");
            string input3 = Console.ReadLine();
            if (!double.TryParse(input2, out double c))
            {
                Console.WriteLine("invalid");
            }


            Trapezium trapezium = new Trapezium(a,b,c);
            double area = trapezium.Area();
            Console.WriteLine($"Trapezium Area : {area}");
        }

        static void Square()
        {
            Console.WriteLine("Enter the side");
            string input = Console.ReadLine();
            if (!double.TryParse(input, out double l))
            {
                Console.WriteLine("invalid");
            }

           

            Rectangle rectangle1 = new Rectangle(l, l);
            double area = rectangle1.Area();
            Console.WriteLine($"Square Area : {area}");
        }
    }
}