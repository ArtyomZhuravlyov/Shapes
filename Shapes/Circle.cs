namespace Shapes
{
    public class Circle : Shape
    {

        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if(radius <= 0)
                throw new ArgumentException("Радиус окружности должен быть больше нуля");

            Radius = radius;
        }

        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
    }
}
