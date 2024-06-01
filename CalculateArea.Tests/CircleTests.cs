using CalculateArea.Models;

namespace CalculateArea.Tests
{
    public class CircleTests
    {

        [Test]
        public void TestCircleArea1()
        {
          var circle = new Circle(5);
          Assert.That(circle.CalculateArea(), Is.EqualTo(Math.PI * 25));
        }

        [Test]
        public void TestCircleArea2()
        {
            var circle = new Circle(7);
            Assert.That(circle.CalculateArea(), Is.EqualTo(Math.PI * 49));
        }

        [Test]
        public void TestCircleRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
    }
}