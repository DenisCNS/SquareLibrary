using SquareLibrary.Solution_Two.Interfaces;

namespace SquareLibrary.Solution_Two.Figures
{
    public class Circle : IHasSquare
    {
        private double _radius;
        public Circle(double radius)
        {
            if (!IsCircleExist(radius))
            {
                throw new ArgumentException("Circle with such radius does not exist");
            }

            _radius = radius;
        }

        public double GetSquare() => Math.PI * Math.Pow(_radius, 2);

        private bool IsCircleExist(double radius) =? radius > 0;        
    }
}
