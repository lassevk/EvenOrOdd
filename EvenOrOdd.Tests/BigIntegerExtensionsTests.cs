using System.Numerics;

namespace EvenOrOdd.Tests;

public class BigIntegerExtensionsTests
{
    [TestCase(-2, true)]
    [TestCase(-1, false)]
    [TestCase(0, true)]
    [TestCase(1, false)]
    [TestCase(2, true)]
    public void IsEven_WithTestCases(int value, bool expected)
    {
        var bi = new BigInteger(value);

        bool output = bi.IsEven();

        Assert.That(output, Is.EqualTo(expected));
    }

    [TestCase(-1, true)]
    [TestCase(-2, false)]
    [TestCase(0, false)]
    [TestCase(1, true)]
    [TestCase(2, false)]
    public void IsOdd_WithTestCases(int value, bool expected)
    {
        var bi = new BigInteger(value);

        bool output = bi.IsOdd();

        Assert.That(output, Is.EqualTo(expected));
    }
}