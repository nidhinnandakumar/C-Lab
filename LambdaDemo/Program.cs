namespace LambdaDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Point> points = new List<Point>
            {
                new Point{X=0,Y=0},
                new Point{X=0,Y=2},
                new Point{X=3,Y=2},
                new Point{X=0,Y=0},
            };

            var innerPoints=points.FindAll(delegate(Point p)
            {
                return p.X>0 && p.Y > 0;
            });

            var innerPoints2=points.FindAll(p=> p.X>0 && p.Y>0);
        }
    }
}