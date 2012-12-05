using System.Collections.Generic;
using System.Linq;

namespace Books
{
	class Catalogue
	{
		private readonly List<Book> _books = new List<Book>();
		public void Add(Book book)
		{
			_books.Add(book);
		}

		public IEnumerable<string> GetTitles()
		{
			return _books.Select(b => b.Title).OrderBy(title => title);
		}
	}
}
