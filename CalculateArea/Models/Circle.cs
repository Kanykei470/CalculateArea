using CalculateArea.Interfaces;

namespace CalculateArea.Models
{
    public class Circle: IShape
    {
        private double radius { get; }
        public double Radius { get { return radius; } }
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть больше нуля.");
            }
            this.radius = radius;
        }

        
        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
