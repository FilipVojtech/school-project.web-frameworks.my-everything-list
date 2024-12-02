using System;
using My_Everything_List.Models;
using NUnit.Framework;

namespace My_Everything_List.Tests.Models;

[TestFixture]
[TestOf(typeof(Film))]
public class FilmTest
{

    [Test]
    public void Equals_Same()
    {
        Film film1 = new Film(1, "Film1", new DateOnly(), ["Genre1"], "Desc1", "/img1.jpg");
        Film film2 = new Film(1, "Film1", new DateOnly(), ["Genre1"], "Desc1", "/img1.jpg");

        Assert.That(film1.Equals(film2), Is.True);
    }

    [Test]
    public void Equals_DifferentTmdbId()
    {
        Film film1 = new Film(1, "Film1", new DateOnly(), ["Genre1"], "Desc1", "/img1.jpg");
        Film film2 = new Film(2, "Film1", new DateOnly(), ["Genre1"], "Desc1", "/img1.jpg");

        Assert.That(film1.Equals(film2), Is.True);
    }

    [Test]
    public void Equals_DifferentTitle()
    {
        Film film1 = new Film(1, "Film1", new DateOnly(), ["Genre1"], "Desc1", "/img1.jpg");
        Film film2 = new Film(1, "Film2", new DateOnly(), ["Genre1"], "Desc1", "/img1.jpg");

        Assert.That(film1.Equals(film2), Is.False);
    }

    [Test]
    public void Equals_DifferentReleaseDate()
    {
        Film film1 = new Film(1, "Film1", new DateOnly(), ["Genre1"], "Desc1", "/img1.jpg");
        Film film2 = new Film(1, "Film1", new DateOnly().AddDays(1), ["Genre1"], "Desc1", "/img1.jpg");

        Assert.That(film1.Equals(film2), Is.False);
    }

    [Test]
    public void Equals_DifferentGenre()
    {
        Film film1 = new Film(1, "Film1", new DateOnly(), ["Genre1"], "Desc1", "/img1.jpg");
        Film film2 = new Film(1, "Film1", new DateOnly(), ["Genre2"], "Desc1", "/img1.jpg");

        Assert.That(film1.Equals(film2), Is.True);
    }

    [Test]
    public void Equals_DifferentDescription()
    {
        Film film1 = new Film(1, "Film1", new DateOnly(), ["Genre1"], "Desc1", "/img1.jpg");
        Film film2 = new Film(1, "Film1", new DateOnly(), ["Genre1"], "Desc2", "/img1.jpg");

        Assert.That(film1.Equals(film2), Is.True);
    }

    [Test]
    public void Equals_DifferentImage()
    {
        Film film1 = new Film(1, "Film1", new DateOnly(), ["Genre1"], "Desc1", "/img1.jpg");
        Film film2 = new Film(1, "Film1", new DateOnly(), ["Genre1"], "Desc1", "/img2.jpg");

        Assert.That(film1.Equals(film2), Is.True);
    }

}
