
using System.Globalization;

namespace UtilityLib.UDataTypes
{
    public class UTemperature : IFormattable, IParsable<UTemperature>
    {
        private decimal _temp;

        public UTemperature(decimal temperature)
        {
            if (temperature < -273.15m)
                throw new ArgumentOutOfRangeException($"{temperature} is less than absolute zero.");

            this._temp = temperature;
        }

        public decimal Celsius => _temp;
        public decimal Fahrenheit => (_temp * 9 / 5) + 32;
        public decimal Kelvin => _temp + 273.15m;

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
            catch { return false; }
        }
    }
}
