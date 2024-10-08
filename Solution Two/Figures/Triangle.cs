﻿using SquareLibrary.Solution_Two.Interfaces;

namespace SquareLibrary.Solution_Two.Figures
{
    public class Triangle : IHasSquare
    {
        private double _side1;
        private double _side2;
        private double _side3;

        public Triangle(double side1, double side2, double side3)
        {
            if (!IsTriangleExist(side1, side2, side3))
            {
                throw new ArgumentException("Triangle with such sides does not exist");
            }

            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double GetSquare()
        {
            var semiperimeter = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(semiperimeter * (semiperimeter - _side1) * (semiperimeter - _side2) * (semiperimeter - _side3));
        }

        public bool IsRight() => _side1 * _side1 + _side2 * _side2 == _side3 * _side3 ||
                                 _side1 * _side1 + _side3 * _side3 == _side2 * _side2 ||
                                 _side2 * _side2 + _side3 * _side3 == _side1 * _side1 ||;

        private bool IsTriangleExist(double side1, double side2, double side3) 
        {
            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                return false;
            }

            var semiperimeter = (side1 + side2 + side3) / 2;
            if (semiperimeter <= side1 || semiperimeter <= side2 || semiperimeter <= side3)
            {
                return false;
            }

            return true;
        }
    }
}
