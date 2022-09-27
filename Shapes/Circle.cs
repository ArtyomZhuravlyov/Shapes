namespace Shapes
{
    public class Circle : Shape
    {

        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if(radius < 0)
                throw new ArgumentException("Радиус окружности не может принимать отрицательное значение");

            Radius = radius;
        }

        public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
    }
}
