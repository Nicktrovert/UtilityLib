using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib.UDataTypes.UDistance;
public partial struct UDistance : IParsable<UDistance>
{
    public static UDistance Parse(string s) => Parse(s, CultureInfo.CurrentCulture);

    public static UDistance Parse(string s, IFormatProvider? provider)
    {
        if (string.IsNullOrEmpty(s))
            throw new ArgumentNullException($"String to parse was null or empty.");

        provider = provider ?? CultureInfo.CurrentCulture;

        string format = s[^1].ToString();
        if (format == " ")
            format = s[^0].ToString();
        else
            format = s[^1].ToString() + s[^0].ToString();

        try
        {
            return format switch
            {
                "mm" => new UDistance(Convert.ToDecimal(s.Remove(s.Length - 2, 2)) * (10 ^ 9)),
                "cm" => new UDistance(Convert.ToDecimal(s.Remove(s.Length - 2, 2)) * (10 ^ 6)),
                "dm" => new UDistance(Convert.ToDecimal(s.Remove(s.Length - 2, 2)) * (10 ^ 3)),
                "m" => new UDistance(Convert.ToDecimal(s.Remove(s.Length - 2, 2))),
                "km" => new UDistance(Convert.ToDecimal(s.Remove(s.Length - 2, 2)) * (10 ^ -3)),
                "Mm" => new UDistance(Convert.ToDecimal(s.Remove(s.Length - 2, 2)) * (10 ^ -6)),
                "Gm" => new UDistance(Convert.ToDecimal(s.Remove(s.Length - 2, 2)) * (10 ^ -9)),
                _ => throw new FormatException()
            };
        }
        catch (FormatException e)
        {
            throw new FormatException($"{s} is an invalid string format.");
        }
    }

    public static bool TryParse(string? s, out UDistance result)
    {
        if (TryParse(s, CultureInfo.CurrentCulture, out UDistance result2))
        {
            result = result2;
            return true;
        }
        else
        {
            result = default;
            return false;
        }
    }

    public static bool TryParse(string? s, IFormatProvider? provider, out UDistance result)
    {
        result = default;
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
