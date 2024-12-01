using My_Everything_List.Models;
using NUnit.Framework;

namespace My_Everything_List.Tests.Models;

[TestFixture]
[TestOf(typeof(Artist))]
public class ArtistTest
{
    [Test]
    public void Equals()
    {
        Artist artist1 = new Artist("Artist1", "/img1.jpg");
        object artist2 = new Artist("Artist1", "/img2.jpg");

        Assert.That(artist1 == (Artist)artist2, Is.True);
    }

    [Test]
    public void NotEquals()
    {
        Artist artist1 = new Artist("Artist1", "/img1.jpg");
        object artist2 = new Artist("Artist2", "/img1.jpg");

        Assert.That(artist1 == (Artist)artist2, Is.False);
    }

    [Test]
    public void NotEquals_Null()
    {
        Artist artist1 = new Artist("Artist1", "/img1.jpg");
        object artist2 = null;

        Assert.That(artist1 == (Artist)artist2, Is.False);
    }
}
