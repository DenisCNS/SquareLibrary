using SquareLibrary.Solution_One.Figures;

namespace SquareLibrary.Figures
{
    public class Circle : Figure
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

        public override double GetSquare() => Math.PI * Math.Pow(_radius, 2);

        private bool IsCircleExist(double radius) 
        {
            return radius > 0;
        }
    }
}