namespace FigureLibrary
{
	public abstract class Figure
	{
		protected double _square;
		public double Square => _square;

		public abstract double CalculateArea();
	}
}