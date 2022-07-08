using FigureLibrary;

namespace FigureLibraryTest
{
	[TestClass]
	public class TriangleTest
	{
		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void ZeroTriangleSideTest()
		{
			Triangle triangle = new Triangle(0, 4, 4);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void NegativeTriangleSideTest()
		{
			Triangle triangle = new Triangle(-11, -16, -15);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void SumOfTwoSidesLessThanThirdTest()
		{
			Triangle triangle = new Triangle(4, 1, 2);
		}

		[TestMethod]
		public void IsRightTriangleTest()
		{
			Triangle triangle = new Triangle(5, 3, 4);
			Assert.IsTrue(triangle.IsRightTriangle());
		}

		[TestMethod]
		public void IsNotRightTriangleTest()
		{
			Triangle triangle = new Triangle(2, 3, 4);
			Assert.IsFalse(triangle.IsRightTriangle());
		}

		[TestMethod]
		public void TriangleAreaTest()
		{
			Triangle triangle = new Triangle(5, 3, 4);

			Assert.AreEqual(6, triangle.CalculateArea());
			Assert.AreEqual(6, triangle.Square);
		}
	}
}
