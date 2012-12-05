using NUnit.Framework;

namespace BooksDone.Tests
{
	[TestFixture]
	public class CatalogueTests
	{
		[Test]
		public void Should_list_all_books()
		{
			Catalogue catalogue = new Catalogue();
			catalogue.Add(new PhysicalBook("1857239407", "George Lucas", "Star Wars: A New Hope", 256, 20));
			catalogue.Add(new Ebook("0450011844", "Frank Herbert", "Dune", 608));

			Assert.That(catalogue.GetTitles(), Is.EqualTo(new[]
			{
				"Dune",
				"Star Wars: A New Hope"
			}));
		}
	}
}
