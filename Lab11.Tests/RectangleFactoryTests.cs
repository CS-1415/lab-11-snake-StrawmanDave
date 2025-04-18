namespace Lab11;

public class RectangleFactoryTests
{
    RectangleFactory rectangleFactory;

    [SetUp]
    public void SetUp()
    {
        rectangleFactory = new RectangleFactory();
    }

    [Test]
    public void FactoryNameTest()
    {
        Assert.That(rectangleFactory.Name, Is.EqualTo("Rectangle"));
    }

    [Test]
    public void ConvertToDecimalTest()
    {
        Assert.That(RectangleFactory.CanBeDecimal("five"), Is.EqualTo(!true));
        Assert.That(RectangleFactory.CanBeDecimal("3.2"), Is.EqualTo(true));
    }
}