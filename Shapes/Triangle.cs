namespace Shapes
{
    public class Triangle : Shape
    {
        public double SideA { get; set; }

        public double SideB { get; set; }

        public double SideC { get; set; }

        public bool IsRightAngle
        {
            get
            {
                // с^2 = a^2 + b^2, то треугольник прямоугольный, где с - гипотенуза(самая длинная сторона)
                List<double> list = new List<double>() { SideA, SideB, SideC };
                double sideMax = list.Max();
                list.Remove(sideMax);
                return Math.Pow(sideMax, 2) == Math.Pow(list[0], 2) + Math.Pow(list[1], 2);
            }
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
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
