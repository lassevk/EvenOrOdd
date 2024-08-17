namespace EvenOrOdd.Tests;

public class UInt32ExtensionsTests
{
    [TestCase(0u, true)]
    [TestCase(1u, false)]
    [TestCase(2u, true)]
    public void IsEven_WithTestCases(uint value, bool expected)
    {
        bool output = value.IsEven();

        Assert.That(output, Is.EqualTo(expected));
    }

    [TestCase(0u, false)]
    [TestCase(1u, true)]
    [TestCase(2u, false)]
    public void IsOdd_WithTestCases(uint value, bool expected)
    {
        bool output = value.IsOdd();

        Assert.That(output, Is.EqualTo(expected));
    }
}