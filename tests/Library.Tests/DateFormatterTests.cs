using TestDateFormat;

namespace Library.Tests
{
    [SetUp]
    public void Setup()
    {
    }
    
    [Test]
    public void DateFormatterTests()
    {
        string testDate = "10/11/1997";
        String x = DateFormatter.ChangeFormat(testDate);

        Assert.AreEqual("1997-11-10",x);
    }
}

