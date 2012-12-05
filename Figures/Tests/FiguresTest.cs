using NUnit.Framework;

namespace Figures.Tests
{
	[TestFixture]
	public class FiguresTest
	{
		[Test]
		public void Should_calculate_circumference_for_rectangle()
		{
			Rectangle rect = new Rectangle();
			rect.A = 3;
			rect.B = 4;
			Assert.That(rect.Circumference(), Is.EqualTo(14));
		}

		[Test]
		public void Should_calculate_circumference_for_square()
		{
			Square square = new Square();
			square.A = 5;
			Assert.That(square.Circumference(), Is.EqualTo(20));
		}		
	}
}
