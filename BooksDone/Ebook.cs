namespace BooksDone
{
	public class Ebook : Book
	{
		public Ebook(string isbn, string author, string title, int pages)
			: base(isbn, author, title, pages) { }
	}
}