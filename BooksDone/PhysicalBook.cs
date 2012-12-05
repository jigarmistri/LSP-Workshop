namespace BooksDone
{
	public class PhysicalBook : Book
	{
		public PhysicalBook(string isbn, string author, string title, int pages, int thickness)
			: base(isbn, author, title, pages)
		{
			Thickness = thickness;
		}

		public int Thickness { get; set; }
	}
}