using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityLib.UDataTypes.UDistance;
public partial struct UDistance : IFormattable
{
    public override string ToString() => this.ToString("G", CultureInfo.CurrentCulture);
    public string ToString(string format) => this.ToString(format, CultureInfo.CurrentCulture);

    public string ToString(string format, IFormatProvider provider)
    {
        if (String.IsNullOrEmpty(format)) format = "G";

        provider = provider ?? CultureInfo.CurrentCulture;

        switch (format)
        {
            case "mm":
                return MiliMeter.ToString("F2", provider) + " " + format;
            case "cm":
                return CentiMeter.ToString("F2", provider) + " " + format;
            case "dm":
                return DeciMeter.ToString("F2", provider) + " " + format;
            case "G":
            case "m":
                return Meter.ToString("F2", provider) + " m";
            case "km":
                return KiloMeter.ToString("F2", provider) + " " + format;
            case "Mm":
                return MegaMeter.ToString("F2", provider) + " " + format;
            case "Gm":
                return GigaMeter.ToString("F2", provider) + " " + format;
            default:
                throw new FormatException($"The {format} format string is not supported.");
        }
    }
}
