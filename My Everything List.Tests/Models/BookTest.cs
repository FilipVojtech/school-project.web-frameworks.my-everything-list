using My_Everything_List.Models;
using NUnit.Framework;

namespace My_Everything_List.Tests.Models;

[TestFixture]
[TestOf(typeof(Book))]
public class BookTest
{
    [Test]
    public void Equals_Same()
    {
        Book book1 = new Book("aaa", "Book1", "Desc1", ["Author1"], "/img1.jpg", "0000000111");
        Book book2 = new Book("aaa", "Book1", "Desc1", ["Author1"], "/img1.jpg", "0000000111");

        Assert.That(book1.Equals(book2), Is.True);
    }

    [Test]
    public void Equals_DifferentGbId()
    {
        Book book1 = new Book("aaa", "Book1", "Desc1", ["Author1"], "/img1.jpg", "0000000111");
        Book book2 = new Book("bbb", "Book1", "Desc1", ["Author1"], "/img1.jpg", "0000000111");

        Assert.That(book1.Equals(book2), Is.True);
    }

    [Test]
    public void Equals_DifferentTitle()
    {
        Book book1 = new Book("aaa", "Book1", "Desc1", ["Author1"], "/img1.jpg", "0000000111");
        Book book2 = new Book("aaa", "Book2", "Desc1", ["Author1"], "/img1.jpg", "0000000111");

        Assert.That(book1.Equals(book2), Is.False);
    }

    [Test]
    public void Equals_DifferentDesc()
    {
        Book book1 = new Book("aaa", "Book1", "Desc1", ["Author1"], "/img1.jpg", "0000000111");
        Book book2 = new Book("aaa", "Book1", "Desc2", ["Author1"], "/img1.jpg", "0000000111");

        Assert.That(book1.Equals(book2), Is.True);
    }

    [Test]
    public void Equals_DifferentAuthor()
    {
        Book book1 = new Book("aaa", "Book1", "Desc1", ["Author1"], "/img1.jpg", "0000000111");
        Book book2 = new Book("aaa", "Book1", "Desc1", ["Author2"], "/img1.jpg", "0000000111");

        Assert.That(book1.Equals(book2), Is.False);
    }

    [Test]
    public void Equals_DifferentImage()
    {
        Book book1 = new Book("aaa", "Book1", "Desc1", ["Author1"], "/img1.jpg", "0000000111");
        Book book2 = new Book("aaa", "Book1", "Desc1", ["Author1"], "/img2.jpg", "0000000111");

        Assert.That(book1.Equals(book2), Is.True);
    }

    [Test]
    public void Equals_DifferentIsbn()
    {
        Book book1 = new Book("aaa", "Book1", "Desc1", ["Author1"], "/img1.jpg", "0000000111");
        Book book2 = new Book("aaa", "Book1", "Desc1", ["Author1"], "/img1.jpg", "0000000222");

        Assert.That(book1.Equals(book2), Is.False);
    }
}
