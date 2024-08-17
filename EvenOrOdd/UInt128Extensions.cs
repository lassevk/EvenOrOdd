using System.Runtime.CompilerServices;

namespace EvenOrOdd;

/// <summary>
/// This class contains some extension methods for <see cref="UInt128"/>.
/// </summary>
public static class UInt128Extensions
{
    /// <summary>
    /// This method returns a value indicating whether the input is even or not.
    /// </summary>
    /// <remarks>
    /// An even number is a number that is wholly divisible by 2.
    /// </remarks>
    /// <param name="value">
    /// The <see cref="UInt128"/> value to determine if is even or not.
    /// </param>
    /// <returns>
    /// <c>true</c> if the <paramref name="value"/> is even;
    /// otherwise, <c>false</c>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsEven(this UInt128 value) => (value & 1) == 0;

    /// <summary>
    /// This method returns a value indicating whether the input is odd or not.
    /// </summary>
    /// <remarks>
    /// An odd number is a number that is not wholly divisible by 2.
    /// </remarks>
    /// <param name="value">
    /// The <see cref="UInt128"/> value to determine if is odd or not.
    /// </param>
    /// <returns>
    /// <c>true</c> if the <paramref name="value"/> is odd;
    /// otherwise, <c>false</c>.
    /// </returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsOdd(this UInt128 value) => (value & 1) != 0;
}