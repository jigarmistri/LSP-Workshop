using NUnit.Framework;

namespace Books.Tests
{
	[TestFixture]
	public class BookShelfTests
	{
		[Test]
		public void Should_tell_me_how_many_books_can_fit_into_it()
		{
			BookShelf bookShelf = new BookShelf(100);
			var book = new PhysicalBook("123", "", "", 100, 20);
			Assert.That(bookShelf.HowManyBooksCanFit(book), Is.EqualTo(5));
		}
	}

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
