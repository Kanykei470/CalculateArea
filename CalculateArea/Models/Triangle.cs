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

        public bool IsRightAngled()
        {
            double[] sides = new double[] { SideA, SideB, SideC };

            // Сортировка длин сторон в порядке возрастания
            for (int i = 0; i < sides.Length - 1; i++)
            {
                for (int j = i + 1; j < sides.Length; j++)
                {
                    if (sides[i] > sides[j])
                    {
                        double temp = sides[i];
                        sides[i] = sides[j];
                        sides[j] = temp;
                    }
                }
            }

            double longestSideSquare = Math.Pow(sides[2], 2);
            double sumOfOtherSquares = Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);

            return Math.Abs(longestSideSquare - sumOfOtherSquares) < 0.0001;
        }


    }
}
