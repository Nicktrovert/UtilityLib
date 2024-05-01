using System.Globalization;

namespace UtilityLib.UDataTypes.UTemperature;

public partial struct UTemperature : IParsable<UTemperature>
{
    public static UTemperature Parse(string s) => Parse(s, CultureInfo.CurrentCulture);

    public static UTemperature Parse(string s, IFormatProvider? provider)
    {
        if (string.IsNullOrEmpty(s))
            throw new ArgumentNullException($"String to parse was null or empty.");

        provider = provider ?? CultureInfo.CurrentCulture;

        string format = s[^1].ToString();

        try
        {
            return format.ToUpperInvariant() switch
            {
                "C" => new UTemperature(Convert.ToDecimal(s.Remove(s.Length - 2, 2))),
                "F" => new UTemperature((Convert.ToDecimal(s.Remove(s.Length - 2, 2)) - 32) * 5 / 9),
                "K" => new UTemperature(Convert.ToDecimal(s.Remove(s.Length - 2, 2)) - 273.15m),
                _ => throw new FormatException()
            };
        }
        catch (FormatException e)
        {
            throw new FormatException($"{s} is an invalid string format.");
        }
    }

    public static bool TryParse(string? s, out UTemperature result)
    {
        if (TryParse(s, CultureInfo.CurrentCulture, out UTemperature result2))
        {
            result = result2;
            return true;
        }
        else
        {
            result = new UTemperature(0);
            return false;
        }
    }

    public static bool TryParse(string? s, IFormatProvider? provider, out UTemperature result)
    {
        result = new UTemperature(0);
        try
        {
            if (String.IsNullOrEmpty(s)) throw new Exception();
            result = Parse(s, provider);
            return true;
        }
        catch
        {
            return false;
        }
    }
}