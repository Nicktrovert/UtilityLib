using System.Globalization;

namespace UtilityLib.UDataTypes.UTemperature;

public partial struct UTemperature : IFormattable
{
    public override string ToString() => this.ToString("G", CultureInfo.CurrentCulture);
    public string ToString(string format) => this.ToString(format, CultureInfo.CurrentCulture);

    public string ToString(string format, IFormatProvider provider)
    {
        if (String.IsNullOrEmpty(format)) format = "G";

        provider = provider ?? CultureInfo.CurrentCulture;

        switch (format.ToUpperInvariant())
        {
            case "G":
            case "C":
                return Celsius.ToString("F2", provider) + " °C";
            case "F":
                return Fahrenheit.ToString("F2", provider) + " °F";
            case "K":
                return Kelvin.ToString("F2", provider) + " K";
            default:
                throw new FormatException($"The {format} format string is not supported.");
        }
    }
}