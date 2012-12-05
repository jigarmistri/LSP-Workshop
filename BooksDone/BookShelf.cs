namespace BooksDone
{
	public class BookShelf
	{
		private readonly int _width;

		public BookShelf(int width)
		{
			_width = width;
		}

		public int HowManyBooksCanFit(PhysicalBook book)
		{
			return _width / book.Thickness;
		}
	}
}