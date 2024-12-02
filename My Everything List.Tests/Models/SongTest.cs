using My_Everything_List.Models;
using NUnit.Framework;

namespace My_Everything_List.Tests.Models;

[TestFixture]
[TestOf(typeof(Song))]
public class SongTest
{
    [Test]
    public void Equals_Same()
    {
        Song song1 = new Song("Song1", "/img1.jpg", "Artist1");
        Song song2 = new Song("Song1", "/img1.jpg", "Artist1");

        Assert.That(song1.Equals(song2), Is.True);
    }

    [Test]
    public void Equals_DifferentName()
    {
        Song song1 = new Song("Song1", "/img1.jpg", "Artist1");
        Song song2 = new Song("Song2", "/img1.jpg", "Artist1");

        Assert.That(song1.Equals(song2), Is.False);
    }

    [Test]
    public void Equals_DifferentImage()
    {
        Song song1 = new Song("Song1", "/img1.jpg", "Artist1");
        Song song2 = new Song("Song1", "/img2.jpg", "Artist1");

        Assert.That(song1.Equals(song2), Is.True);
    }

    [Test]
    public void Equals_DifferentArtist()
    {
        Song song1 = new Song("Song1", "/img1.jpg", "Artist1");
        Song song2 = new Song("Song1", "/img1.jpg", "Artist2");

        Assert.That(song1.Equals(song2), Is.False);
    }
}
