using My_Everything_List.Models;
using NUnit.Framework;

namespace My_Everything_List.Tests.Models;

[TestFixture]
[TestOf(typeof(Artist))]
public class ArtistTest
{
    [Test]
    public void Equals_Same()
    {
        Artist artist1 = new Artist("Artist1", "/img1.jpg");
        Artist artist2 = new Artist("Artist1", "/img1.jpg");

        Assert.That(artist1.Equals(artist2), Is.True);
    }

    [Test]
    public void Equals_DifferentName()
    {
        Artist artist1 = new Artist("Artist1", "/img1.jpg");
        Artist artist2 = new Artist("Artist2", "/img1.jpg");

        Assert.That(artist1.Equals(artist2), Is.False);
    }

    [Test]
    public void Equals_DifferentImage()
    {
        Artist artist1 = new Artist("Artist1", "/img1.jpg");
        Artist artist2 = new Artist("Artist1", "/img2.jpg");

        Assert.That(artist1.Equals(artist2), Is.True);
    }
}
