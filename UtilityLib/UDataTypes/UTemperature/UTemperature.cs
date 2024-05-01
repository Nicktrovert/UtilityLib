namespace UtilityLib.UDataTypes.UTemperature;

public partial struct UTemperature
{
    private decimal _temp;

    public UTemperature(decimal temperature)
    {
        if (temperature < -273.15m)
            throw new ArgumentOutOfRangeException($"{temperature} is less than absolute zero.");
        _temp = temperature;
    }

    public decimal Celsius => _temp;
    public decimal Fahrenheit => (_temp * 9 / 5) + 32;
    public decimal Kelvin => _temp + 273.15m;
}