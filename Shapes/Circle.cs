namespace Shapes
{
    public class Circle : Shape
    {

        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
    }
}
