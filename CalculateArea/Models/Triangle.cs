using CalculateArea.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea.Models
{
    public class Triangle : IShape
    {
        private double sideA {  get; set; }
        private double sideB {  get; set; }
        private double sideC {  get; set; }
        public double SideA
        {
            get { return sideA; }
        }

        public double SideB
        {
            get { return sideB; }
        }

        public double SideC
        {
            get { return sideC; }
        }

        public Triangle(double sideA,double sideB,double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Стороны должны быть больше 0.");
            }

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("Сумма двух любых сторон должна быть больше третьей стороны.");
            }

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double CalculateArea()
        {
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }

    }
}
