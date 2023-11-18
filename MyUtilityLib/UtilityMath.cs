namespace UtilityLib.UMath;

/// <summary>
/// Provides utility methods for mathematical operations.
/// </summary>
public static class UtilityMath
{
    /// <summary>
    /// Checks if an <see cref="int"/> is odd.
    /// </summary>
    /// <param name="input">The integer to check.</param>
    /// <returns><c>true</c> if <paramref name="input"/> is odd; otherwise, <c>false</c>.</returns>
    public static bool IsOdd(int input)
    {
        return input % 2 != 0;
    }

    /// <summary>
    /// Checks if an <see cref="int"/> is even.
    /// </summary>
    /// <param name="input">The integer to check.</param>
    /// <returns><c>true</c> if <paramref name="input"/> is even; otherwise, <c>false</c>.</returns>
    public static bool IsEven(int input)
    {
        return input % 2 == 0;
    }

    /// <summary>
    /// Checks if an <see cref="int"/> is a prime number.
    /// </summary>
    /// <param name="input">The integer to check.</param>
    /// <returns><c>true</c> if <paramref name="input"/> is a prime number; otherwise, <c>false</c>.</returns>
    public static bool IsPrime(int input)
    {
        if (input == 2)
            return true;

        if (input <= 1 || IsEven(input))
            return false;

        var boundary = (int)Math.Floor(Math.Sqrt(input));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (input % i == 0)
                return false;
        }

        return true;
    }
}
