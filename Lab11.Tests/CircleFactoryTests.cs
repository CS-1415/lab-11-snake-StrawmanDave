namespace Lab11.Tests;

public class CirlceFactoryTests
{
    CirlceFactory circleFactory;
    [SetUp]
    public void SetUp()
    {
        circleFactory = new CirlceFactory();
    }
    [Test]
    public void FactoryNameTest()
    {
        Assert.That(circleFactory.Name, Is.EqualTo("Circle"));
    }
    [Test]
    public void ConvertToDecimalTest()
    {
        Assert.That(CirlceFactory.CanBeDecimal("Five"), Is.EqualTo(!true));
        Assert.That(CirlceFactory.CanBeDecimal("5.2"), Is.EqualTo(true));
    }
}