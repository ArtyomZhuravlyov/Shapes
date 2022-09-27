namespace Shapes
{
    public class Triangle : Shape
    {
        public double SideA { get; private set; }

        public double SideB { get; private set; }

        public double SideC { get; private set; }

        public bool IsRightAngle
        {
            get
            {
                // с^2 = a^2 + b^2, то треугольник прямоугольный, где с - гипотенуза
                List<double> list = new List<double>() { SideA, SideB, SideC };
                double sideMax = list.Max(); //гипотенуза
                list.Remove(sideMax);
                return Math.Pow(sideMax, 2) == Math.Pow(list[0], 2) + Math.Pow(list[1], 2);
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if(sideA < 0 || sideB < 0 || sideC < 0)
            {
                throw new ArgumentException("Сторона треугольника не может принимать отрицательное значение");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double GetArea()
        {
            // По формуле Герона
            var p = 0.5 * (SideA + SideB + SideC);
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
    }
}
