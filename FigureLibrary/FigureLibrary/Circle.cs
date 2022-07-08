namespace FigureLibrary
{
	public class Circle : Figure
	{
		public readonly double Radius;
		public Circle(double radius)
		{
			if (!IsExists(radius))
			{
				throw new ArgumentException(String.Format("Radius can't be {0}", radius));
			}

			Radius = radius;
			_square = CalculateArea();
		}

		private bool IsExists(double radius)
		{
			if (radius <= 0)
			{
				return false;
			}
			return true;
		}
		public override double CalculateArea()
		{
			return Math.PI * Radius * Radius;
		}
	}
}
