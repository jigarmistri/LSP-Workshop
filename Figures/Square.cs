namespace Figures
{
	public class Square : Rectangle
	{
		public override int B
		{
			get
			{
				return base.A;
			}
			set
			{
				base.A = value;
			}
		}
	}
}