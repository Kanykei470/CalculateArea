using CalculateArea.Models;
using CalculateArea.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea.Tests
{
    public class AreaCalculatorTests
    {
        [Test]
        public void TestCalculateArea()
        {
            var calculator = new AreaCalculator();

            var circle = new Circle(5);
            Assert.That(calculator.CalculateArea(circle), Is.EqualTo(Math.PI * 25));

            var triangle = new Triangle(3, 4, 5);
            Assert.That(calculator.CalculateArea(triangle), Is.EqualTo(6));
        }
    }
}
