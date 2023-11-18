namespace MyUtilityLib;

public static class UtilityMath
{

    /// <summary>
    /// Checks if a <see cref="int"/> is odd.
    /// </summary>
    /// <param name="Input"></param>
    /// <returns><see langword="true"/> if <paramref name="Input"/> is Odd and <see langword="false"/> if <paramref name="Input"/> is not Odd.</returns>
    public static bool IsOdd(int Input)
    {

        if (Input % 2 == 0)
        {
            return false;
        }
        else
        {
            return true;
        }

    }

    /// <summary>
    /// Checks if a <see cref="int"/> is even.
    /// </summary>
    /// <param name="Input"></param>
    /// <returns><see langword="true"/> if <paramref name="Input"/> is Even and <see langword="false"/> if <paramref name="Input"/> is not Even.</returns>
    public static bool IsEven(int Input)
    {

        if (Input % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    /// <summary>
    /// Checks if a <see cref="int"/> is a prime number
    /// </summary>
    /// <param name="Input"></param>
    /// <returns><see langword="true"/> if <paramref name="Input"/> is a Prime number and <see langword="false"/> if <paramref name="Input"/> is not a Prime number</returns>
    public static bool IsPrime(int Input)
    {

        if (Input == 2) { return true; }
        if (Input <= 1 || Input % 2 == 0) { return false; }

        var boundary = (int)Math.Floor(Math.Sqrt(Input));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (Input % i == 0) { return false; }
        }

        return true;

    }

}

public static class UtilityString
{

    /// <summary>
    /// Changes the first <see cref="char"/> of the <paramref name="Input"/> <see cref="string"/> to uppercase.
    /// </summary>
    /// <param name="Input"></param>
    /// <returns><see cref="string"/> with first letter uppercase.</returns>
    public static string UpperFirstChar(string Input)
    {

        char[] chars = Input.ToCharArray();

        for (int i = 0; i < Input.Length; i++)
        {
            if (Char.IsLetter(chars[i]))
            {
                chars[i] = chars[i].ToString().ToUpper().ToCharArray()[0];
                break;
            }
        }

        string result = "";

        foreach (char c in chars) { result += c; }

        return result;

    }

    /// <summary>
    /// Changes the first <see cref="char"/> of each <see cref="string"/> in the <paramref name="Input"/> <see cref="IList{T}"/> to uppercase.
    /// </summary>
    /// <param name="Input"></param>
    /// <returns><see cref="IList{T}"/> of <see cref="string"/>.</returns>
    public static IList<string> UpperFirstChar(IList<string> Input)
    {

        string[] result = new string[Input.Count];

        for (int i = 0; i < Input.Count; i++) { result[i] = UpperFirstChar(Input[i]); }

        return result;

    }

    /// <summary>
    /// Changes the first <see cref="char"/> of each word in <paramref name="Input"/> <see cref="string"/> to uppercase.
    /// </summary>
    /// <param name="Input"></param>
    /// <returns><see cref="string"/> with first letter of each word uppercase.</returns>
    public static string UpperEachFirstChar(string Input)
    {

        string[] splitstring = Input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

        string result = "";

        foreach (string s in splitstring) { result += UpperFirstChar(s) + " "; }

        return result;

    }

    /// <summary>
    /// Changes the first <see cref="char"/> of each word in each <paramref name="Input"/> <see cref="string"/> to uppercase.
    /// </summary>
    /// <param name="Input"></param>
    /// <returns><see cref="IList{T}"/> of <see cref="string"/>.</returns>
    public static IList<string> UpperEachFirstChar(IList<string> Input)
    {

        string[] result = new string[Input.Count];

        for (int i = 0; i < Input.Count; i++) { result[i] = UpperEachFirstChar(Input[i]); }

        return result;

    }

}

