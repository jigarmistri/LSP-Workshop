namespace FiguresDone
{
	public class Rectangle : IShape
	{
		public int A { get; set; }
		public int B { get; set; }

		public int Circumference()
		{
			return 2 * A + 2 * B;
		}
	}
}
