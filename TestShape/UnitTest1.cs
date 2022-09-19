using Shapes;
using System;
using Xunit;

namespace ShapesTest
{
    public class UnitTest1
    {
        [Fact]
        public void TestTriangleRigthAngle()
        {
            var triangle = new Triangle(4, 3, 4); // непрямоугольные треугольники
            Assert.False(triangle.IsRightAngle);

            triangle = new Triangle(6, 8, 9);
            Assert.False(triangle.IsRightAngle);

            triangle = new Triangle(4, 3, 5);     // прямоугольные треугольники
            Assert.True(triangle.IsRightAngle);

            triangle = new Triangle(6, 8, 10);
            Assert.True(triangle.IsRightAngle);

        }

        [Fact]
        public void TestArea()
        {
            var triangle = new Triangle(4, 3, 4); // непрямоугольные треугольники
            Assert.Equal(5.56, Math.Round(triangle.GetArea(), 2));

            triangle = new Triangle(6, 8, 9);
            Assert.Equal(23.53, Math.Round(triangle.GetArea(), 2));

            triangle = new Triangle(4, 3, 5);     // прямоугольные треугольники
            Assert.Equal(6, triangle.GetArea());

            triangle = new Triangle(6, 8, 10);
            Assert.Equal(24, triangle.GetArea());


            var circle = new Circle(1);           // окружности                            
            Assert.Equal(Math.PI, circle.GetArea());

            circle = new Circle(2);
            Assert.Equal(12.57, Math.Round(circle.GetArea(), 2));

            Shape shape = new Circle(2);          // Вычисление площади фигуры без знания типа фигуры (compile-time)
            Assert.Equal(12.57, Math.Round(shape.GetArea(), 2));

            shape = new Triangle(6, 8, 10);
            Assert.Equal(24, shape.GetArea());

        }
    }
}