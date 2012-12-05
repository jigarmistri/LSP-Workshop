namespace Figures
{
	public class Rectangle
	{
		public virtual int A { get; set; }
		public virtual int B { get; set; }

		public int Circumference()
		{
			return 2 * A + 2 * B;
		}
	}
}
