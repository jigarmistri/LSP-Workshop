using NUnit.Framework;

namespace BooksDone.Tests
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
}
