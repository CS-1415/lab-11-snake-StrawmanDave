using System.Diagnostics;
namespace Lab11.Tests;

public class CircleTests
{
    Circle circle;
    AbstractGraphic2D shape;

    [SetUp]
    public void Setup()
    {
        // should be x, y, and radius
        circle = new Circle(8, 10, 2);

        // should extend the abstract class
        shape = circle;
    }

    [Test]
    public void CircleHasCorrectDimensions()
    {
        Assert.That(circle.CenterX, Is.EqualTo(8));
        //Assert.AreEqual(8, circle.CenterX);
        Assert.That(circle.CenterY, Is.EqualTo(10));
        //Assert.AreEqual(10, circle.CenterY);
        Assert.That(circle.Radius, Is.EqualTo(2));
        //Assert.AreEqual(2, circle.Radius);
    }

    [Test]
    public void HasCorrectBoundingBox()
    {
        Assert.That(shape.LowerBoundX, Is.EqualTo(8 - 2));
        //Assert.AreEqual(8 - 2, shape.LowerBoundX);
        Assert.That(shape.LowerBoundY, Is.EqualTo(10 - 2));
        //Assert.AreEqual(10 - 2, shape.LowerBoundY);
        Assert.That(shape.UpperBoundX, Is.EqualTo(8 + 2));
        //Assert.AreEqual(8 + 2, shape.UpperBoundX);
        Assert.That(shape.UpperBoundY, Is.EqualTo(10 + 2));
        //Assert.AreEqual(10 + 2, shape.UpperBoundY);
    }

    [Test]
    public void CenterIsIncluded()
    {
        Debug.Assert(shape.ContainsPoint(8, 10));
        //Assert.IsTrue(shape.ContainsPoint(8, 10));
    }

    [Test]
    public void ContainsAllFourPointsOfTheCompass()
    {
        Debug.Assert(shape.ContainsPoint(8 - 2, 10));
        //Assert.IsTrue(shape.ContainsPoint(8 - 2,10));
        Debug.Assert(shape.ContainsPoint(8 + 2, 10));
        //Assert.IsTrue(shape.ContiansPoint(8 + 2, 10));
        Debug.Assert(shape.ContainsPoint(8, 10 - 2));
        //Assert.IsTrue(shape.ContainsPoint(8,10 - 2));
        Debug.Assert(shape.ContainsPoint(8, 10 + 2));
        //Assert.IsTrue(shape.ContainsPoint(8, 10 +2));
    }

    [Test]
    public void ShouldNotContainFourCorners()
    {
        Debug.Assert(!shape.ContainsPoint(8 - 2, 10 - 2));
        //Assert.IsFalse(shape.ContainsPoint(8 - 2, 10 - 2));
        Debug.Assert(!shape.ContainsPoint(8 + 2, 10 - 2));
        //Assert.IsFalse(shape.ContainsPoint(8 + 2, 10 - 2));
        Debug.Assert(!shape.ContainsPoint(8 - 2, 10 + 2));
        //Assert.IsFalse(shape.ContainsPoint(8 - 2, 10 + 2));
        Debug.Assert(!shape.ContainsPoint(8 + 2, 10 + 2));
        //Assert.IsFalse(shape.ContainsPoint(8 + 2, 10 + 2));
    }
}