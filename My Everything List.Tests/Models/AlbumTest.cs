using My_Everything_List.Models;
using NUnit.Framework;

namespace My_Everything_List.Tests.Models;

[TestFixture]
[TestOf(typeof(Album))]
public class AlbumTest
{
    [Test(Description = "Albums equal when all of their properties are the same, regardless of image")]
    public void Equals()
    {
        Album album1 = new Album("Album1", "/img1.jpg", "Artist1");
        object album2 = new Album("Album1", "/img2.jpg", "Artist1");

        Assert.That(album1.Equals(album2), Is.True);
    }

    [Test(Description = "Albums not equal when at least one of their properties is different")]
    public void NotEquals()
    {
        Album album1 = new Album("Album1", "/img1.jpg", "Artist1");
        object album2 = new Album("Album1", "/img1.jpg", "Artist2");

        Assert.That(album1.Equals(album2), Is.False);
    }
}
