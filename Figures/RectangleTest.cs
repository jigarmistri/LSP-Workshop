using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace Figures
{
	[TestFixture]
	public class RectangleTest
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

		[Test]
		public void Should_set_sides_and_calculates_circumference_for_rectangle()
		{
			Assert.That(CalculateCircumferenceForRectangle(new Rectangle()), Is.EqualTo(18));
		}

		[Test]
		public void Should_set_sides_and_calculates_circumference_for_square()
		{
			Assert.That(CalculateCircumferenceForSquare(new Square()), Is.EqualTo(16));
		}

		[Test]
		public void ShouldTotalCircumferenceCalculator_return_correct_sum()
		{
			IShape square = new Square { A = 4 };
			IShape rect = new Rectangle { A = 4, B = 5 };
			TotalCircumferenceCalculator calculator = new TotalCircumferenceCalculator();
			calculator.Add(square);
			calculator.Add(rect);
			Assert.That(calculator.GetTotal(), Is.EqualTo(square.Circumference() + rect.Circumference()));
		}

		int CalculateCircumferenceForRectangle(Rectangle rect)
		{
			rect.A = 4;
			rect.B = 5;
			return rect.Circumference();
		}

		int CalculateCircumferenceForSquare(Square rect)
		{
			rect.A = 4;
			return rect.Circumference();
		}
	}

	class TotalCircumferenceCalculator
	{
		private readonly List<IShape> _shapes = new List<IShape>();

		public void Add(IShape shape) { _shapes.Add(shape); }

		public int GetTotal()
		{
			return _shapes.Sum(shape => shape.Circumference());
		}
	}
}
