namespace EvenOrOdd.Tests;

public class SByteExtensionsTests
{
    [TestCase(-2, true)]
    [TestCase(-1, false)]
    [TestCase(0, true)]
    [TestCase(1, false)]
    [TestCase(2, true)]
    public void IsEven_WithTestCases(sbyte value, bool expected)
    {
        bool output = value.IsEven();

        Assert.That(output, Is.EqualTo(expected));
    }

    [TestCase(-1, true)]
    [TestCase(-2, false)]
    [TestCase(0, false)]
    [TestCase(1, true)]
    [TestCase(2, false)]
    public void IsOdd_WithTestCases(sbyte value, bool expected)
    {
        bool output = value.IsOdd();

        Assert.That(output, Is.EqualTo(expected));
    }
}