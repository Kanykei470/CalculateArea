using CalculateArea.Interfaces;
using CalculateArea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea.Tests
{
    public class TriangleTests 
    {
        [Test]
        public void TestTriangleArea1()
        {
            var triangle = new Triangle(14,13,15);
            Assert.That(triangle.CalculateArea(), Is.EqualTo(84));
        }

        [Test]
        public void TestTriangleArea2()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.That(triangle.CalculateArea(), Is.EqualTo(6));
        }

        [Test]
        public void TestTriangleSides()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 4, 5));
            Assert.Throws<ArgumentException>(() => new Triangle(3, 0, 5));
            Assert.Throws<ArgumentException>(() => new Triangle(3, 4, 0));
            Assert.Throws<ArgumentException>(() => new Triangle(-3, 4, 5));
            Assert.Throws<ArgumentException>(() => new Triangle(3, -4, 5));
            Assert.Throws<ArgumentException>(() => new Triangle(3, 4, -5));
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));
        }
    }
}
