namespace EvenOrOdd.Tests;

public class UInt128ExtensionsTests
{
    private static IEnumerable<TestCaseData> IsEvenTestCases()
    {
        yield return new TestCaseData((UInt128)0, true);
        yield return new TestCaseData((UInt128)1, false);
        yield return new TestCaseData((UInt128)2, true);
    }

    [TestCaseSource(nameof(IsEvenTestCases))]
    public void IsEven_WithTestCases(UInt128 value, bool expected)
    {
        bool output = value.IsEven();

        Assert.That(output, Is.EqualTo(expected));
    }

    private static IEnumerable<TestCaseData> IsOddTestCases()
    {
        yield return new TestCaseData((UInt128)0, false);
        yield return new TestCaseData((UInt128)1, true);
        yield return new TestCaseData((UInt128)2, false);
    }

    [TestCaseSource(nameof(IsOddTestCases))]
    public void IsOdd_WithTestCases(UInt128 value, bool expected)
    {
        bool output = value.IsOdd();

        Assert.That(output, Is.EqualTo(expected));
    }
}