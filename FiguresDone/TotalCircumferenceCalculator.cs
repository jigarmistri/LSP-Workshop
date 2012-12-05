using System.Collections.Generic;
using System.Linq;

namespace FiguresDone
{
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