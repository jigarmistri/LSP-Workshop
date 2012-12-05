namespace FiguresDone
{
	public class Square : IShape
	{
		public int A { get; set; }

		public virtual int Circumference()
		{
			return 4 * A;
		}
	}
}