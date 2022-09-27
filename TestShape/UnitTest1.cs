using Shapes;
using System;
using Xunit;

namespace ShapesTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Проверка, что треугольник прямоугольный
        /// </summary>
        [Fact]
        public void CheckTriangleRigthAngle()
        {
            var triangle = new Triangle(4, 3, 5);     
            Assert.True(triangle.IsRightAngle);

            triangle = new Triangle(6, 8, 10);
            Assert.True(triangle.IsRightAngle);
        }

        /// <summary>
        /// Проверка, что треугольник непрямоугольный
        /// </summary>
        [Fact]
        public void CheckTriangleNotRigthAngle()
        {
            var triangle = new Triangle(4, 3, 4); 
            Assert.False(triangle.IsRightAngle);

            triangle = new Triangle(6, 8, 9);
            Assert.False(triangle.IsRightAngle);
        }

        /// <summary>
        /// Проверка вычисления площади треугольника
        /// </summary>
        [Fact]
        public void CheckAreaTriangle()
        {
            var triangle = new Triangle(4, 3, 5);     
            Assert.Equal(6, triangle.GetArea());

            triangle = new Triangle(4, 3, 4);
            Assert.Equal(5.56, Math.Round(triangle.GetArea(), 2));
        }

        /// <summary>
        /// Проверка вычисления площади окружности
        /// </summary>
        [Fact]
        public void CheckAreaCircle()
        {
            var circle = new Circle(1);                                 
            Assert.Equal(Math.PI, circle.GetArea());

            circle = new Circle(2);
            Assert.Equal(12.57, Math.Round(circle.GetArea(), 2));
        }


        /// <summary>
        /// Проверка вычисления площади фигуры без знания типа фигуры (compile-time)
        /// </summary>
        [Fact]
        public void CheckAreaShape()
        {
            Shape shape = new Circle(2);          
            Assert.Equal(12.57, Math.Round(shape.GetArea(), 2));

            shape = new Triangle(6, 8, 10);
            Assert.Equal(24, shape.GetArea());
        }
    }
}