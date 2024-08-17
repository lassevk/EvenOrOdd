namespace EvenOrOdd.Tests;

public class UInt16ExtensionsTests
{
    [TestCase((ushort)0, true)]
    [TestCase((ushort)1, false)]
    [TestCase((ushort)2, true)]
    public void IsEven_WithTestCases(ushort value, bool expected)
    {
        bool output = value.IsEven();

        Assert.That(output, Is.EqualTo(expected));
    }

    [TestCase((ushort)0, false)]
    [TestCase((ushort)1, true)]
    [TestCase((ushort)2, false)]
    public void IsOdd_WithTestCases(ushort value, bool expected)
    {
        bool output = value.IsOdd();

        Assert.That(output, Is.EqualTo(expected));
    }
}