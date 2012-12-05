namespace BooksDone
{
	public class Book
	{
		public Book(string isbn, string author, string title, int pages)
		{
			ISBN = isbn;
			Author = author;
			Title = title;
			Pages = pages;
		}
		public int Pages { get; private set; }
		public string Title { get; private set; }
		public string Author { get; private set; }
		public string ISBN { get; private set; }
	}
}
