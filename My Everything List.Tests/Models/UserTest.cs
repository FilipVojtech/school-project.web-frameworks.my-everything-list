using My_Everything_List.Models;
using NUnit.Framework;

namespace My_Everything_List.Tests.Models;

[TestFixture]
[TestOf(typeof(User))]
public class UserTest
{

    [Test]
    public void Equals_Same()
    {
        User user1 = new User("test@test.com", "Password", "User");
        User user2 = new User("test@test.com", "Password", "User");

        Assert.That(user1.Equals(user2), Is.True);
    }

    [Test]
    public void Equals_DifferentEmail()
    {
        User user1 = new User("test@test.com", "Password", "User");
        User user2 = new User("test2@test.com", "Password", "User");

        Assert.That(user1.Equals(user2), Is.False);
    }

    [Test]
    public void Equals_DifferentPassword()
    {
        User user1 = new User("test@test.com", "Password", "User");
        User user2 = new User("test@test.com", "Password2", "User");

        Assert.That(user1.Equals(user2), Is.True);
    }

    [Test]
    public void Equals_DifferentRole()
    {
        User user1 = new User("test@test.com", "Password", "User");
        User user2 = new User("test@test.com", "Password", "Admin");

        Assert.That(user1.Equals(user2), Is.True);
    }

}
