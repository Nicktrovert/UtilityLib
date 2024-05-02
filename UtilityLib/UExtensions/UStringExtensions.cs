using System.Text.RegularExpressions;

namespace UtilityLib.UExtensions;

public static class UStringExtensions
{
    public static string UpperFirstChar(this string var)
    {
        var chars = var.ToCharArray();

        for (int i = 0; i < var.Length; i++)
        {
            if (!char.IsLetter(chars[i])) continue;
            chars[i] = char.ToUpper(chars[i]);
            break;
        }

        var = new string(chars);
        return var;
    }
    
    public static IList<string> UpperFirstChar(this IList<string> var)
    {
        foreach (var v in var)
            v.UpperFirstChar();
        return var;
    }
    
    public static string UpperEachFirstChar(this string var, bool SymbolsAsWordSeperators = false)
    {
        string[] splitString;

        // Split by both spaces and symbols or just spaces
        splitString = SymbolsAsWordSeperators ? Regex.Split(var, @"(?<=[^\w\s])|(?=[^\w\s])") : var.Split(new[] { ' ' }, StringSplitOptions.None);

        for (int i = 0; i < splitString.Length; i++)
        {
            splitString[i] = UpperFirstChar(splitString[i]);
        }

        var = string.Join(SymbolsAsWordSeperators ? "" : " ", splitString);
        return var;
    }
    
    public static IList<string> UpperEachFirstChar(this IList<string> var, bool SymbolsAsWordSeperetaros = false)
    {
        var = var.Select(str => str.UpperEachFirstChar(SymbolsAsWordSeperetaros)).ToList();
        return var;
    }
}