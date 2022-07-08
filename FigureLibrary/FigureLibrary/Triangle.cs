namespace FigureLibrary
{
	public class Triangle : Figure
	{
		public double[] Sides { get; }

		public Triangle(double firstSide, double secondSide, double thirdSide)
		{
			if (!IsExists(firstSide, secondSide, thirdSide))
			{
				throw new ArgumentException(String.Format("Triangle with sides {0}, {1}, {2} doesn't exist",
					firstSide, secondSide, thirdSide));
			}

			Sides = new double[] { firstSide, secondSide, thirdSide };
			_square = CalculateArea();
		}

		private bool IsExists(double firstSide, double secondSide, double thirdSide)
		{
			if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
			{
				return false;
			}
			if (firstSide + secondSide > thirdSide
				&& firstSide + thirdSide > secondSide
				&& secondSide + thirdSide > firstSide)
			{
				return true;
			}
			return false;
		}

		public bool IsRightTriangle()
		{
			double sideSums = 0;

			foreach (int i in Sides)
			{
				sideSums += i * i;
			}

			return 2 * Sides.Max() * Sides.Max() == sideSums;
		}

		public override double CalculateArea()
		{
			double semiPerimeter = Sides.Sum() / 2;
			double area = semiPerimeter;

			foreach (int i in Sides)
			{
				area *= semiPerimeter - i;
			}

			return Math.Sqrt(area);
		}
	}
}
