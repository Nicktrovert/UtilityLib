using System.Text.RegularExpressions;

namespace UtilityLib.UString;

/// <summary>
/// Provides utility methods for string manipulations.
/// </summary>
public static class UtilityString
{
    /// <summary>
    /// Converts the first <see cref="char"/> of the <paramref name="input"/> <see cref="string"/> to uppercase.
    /// </summary>
    /// <param name="input">The input string.</param>
    /// <returns><see cref="string"/> with the first letter in uppercase.</returns>
    public static string UpperFirstChar(string input)
    {
        var chars = input.ToCharArray();

        for (int i = 0; i < input.Length; i++)
        {
            if (!char.IsLetter(chars[i])) continue;
            chars[i] = char.ToUpper(chars[i]);
            break;
        }

        return new string(chars);
    }

    /// <summary>
    /// Converts the first <see cref="char"/> of each <see cref="string"/> in the <paramref name="input"/> <see cref="IList{T}"/> to uppercase.
    /// </summary>
    /// <param name="input">The input list of strings.</param>
    /// <returns><see cref="IList{T}"/> of strings with the first letter in uppercase.</returns>
    public static IList<string> UpperFirstChar(IList<string> input)
    {
        return input.Select(UpperFirstChar).ToList();
    }

    /// <summary>
    /// Converts the first <see cref="char"/> of each word in the <paramref name="input"/> <see cref="string"/> to uppercase.
    /// </summary>
    /// <param name="input">The input string.</param>
    /// <param name="SymbolsAsWordSeperators">Specifies whether symbols should be considered as word separators.</param>
    /// <returns><see cref="string"/> with the first letter of each word in uppercase.</returns>
    public static string UpperEachFirstChar(string input, bool SymbolsAsWordSeperators = false)
    {
        string[] splitString;

        // Split by both spaces and symbols or just spaces
        splitString = SymbolsAsWordSeperators ? Regex.Split(input, @"(?<=[^\w\s])|(?=[^\w\s])") : input.Split(new[] { ' ' }, StringSplitOptions.None);

        for (int i = 0; i < splitString.Length; i++)
        {
            splitString[i] = UpperFirstChar(splitString[i]);
        }

        return string.Join(SymbolsAsWordSeperators ? "" : " ", splitString);
    }

    /// <summary>
    /// Converts the first <see cref="char"/> of each word in each <see cref="string"/> in the <paramref name="input"/> <see cref="IList{T}"/> to uppercase.
    /// </summary>
    /// <param name="input">The input list of strings.</param>
    /// <param name="SymbolsAsWordSeperetaros">Specifies whether symbols should be considered as word separators.</param>
    /// <returns><see cref="IList{T}"/> of strings with the first letter of each word in uppercase.</returns>
    public static IList<string> UpperEachFirstChar(IList<string> input, bool SymbolsAsWordSeperetaros = false)
    {
        return input.Select(str => UpperEachFirstChar(str, SymbolsAsWordSeperetaros)).ToList();
    }
}
