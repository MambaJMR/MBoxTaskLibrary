using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBoxTaskLibrary
{
    public class Triangle : Figure
    {

        double a, b, c, perimetr, square;
        public Triangle(double sideA, double sideB, double sideC)
        {
            a = sideA;
            b = sideB;
            c = sideC;

            if (a <= 0 | b <= 0 | c <= 0)
            {
                throw new Exception("Стороны треугольника не могут быть меньше либо равны нулю");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new Exception("Такого треугольника не может существовать.");
            }
        }
        public override double Square()
        {
            perimetr = (a + b + c) / 2;

            return square = Math.Round(Math.Sqrt(perimetr * (perimetr - a) * (perimetr - b) * (perimetr - c)), 4);
        }
        public bool CheckingTheTriangle()
        {
            // Проверка является ли треугольник прямоугольным
            return (a == Math.Sqrt(Math.Pow(b, 2) + Math.Pow(c, 2))
                   || b == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2))
                   || c == Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))) ? true : false;
        }
    }
}

