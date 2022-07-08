using FigureLibrary;

namespace FigureLibraryTest;

[TestClass]
public class CircleTest
{
	[TestMethod]
	[ExpectedException(typeof(ArgumentException))]
	public void ZeroCircleRadiusTest()
	{
		Circle circle = new Circle(0);
	}

	[TestMethod]
	[ExpectedException(typeof(ArgumentException))]
	public void NegativeCircleRadiusTest()
	{
		Circle circle = new Circle(-12.4);
	}

	[TestMethod]
	public void CircleAreaTest()
	{
		double radius = 0.1;
		Circle circle = new Circle(radius);

		Assert.AreEqual(Math.PI * radius * radius, circle.CalculateArea());
		Assert.AreEqual(Math.PI * radius * radius, circle.Square);
	}
}