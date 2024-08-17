namespace EvenOrOdd.Tests;

public class UInt64ExtensionsTests
{
    [TestCase((ulong)0, true)]
    [TestCase((ulong)1, false)]
    [TestCase((ulong)2, true)]
    public void IsEven_WithTestCases(ulong value, bool expected)
    {
        bool output = value.IsEven();

        Assert.That(output, Is.EqualTo(expected));
    }


    [TestCase((ulong)0, false)]
    [TestCase((ulong)1, true)]
    [TestCase((ulong)2, false)]
    public void IsOdd_WithTestCases(ulong value, bool expected)
    {
        bool output = value.IsOdd();

        Assert.That(output, Is.EqualTo(expected));
    }
}