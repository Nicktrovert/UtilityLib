using UtilityLib.UDataTypes;

namespace UtilityLibTesting;

public static class UTemperatureTesting
{
    public static void UTemperatureMain()
    {
        Console.WriteLine("### Started Testing UList ### \n");

        UTemperature temp = new UTemperature(0);
        Console.WriteLine($"0°C to Kelvin: {temp.ToString("K")}");
        Console.WriteLine($"0°C to Fahrenheit: {temp.ToString("F")}");
        Console.WriteLine($"0°C to Celsius: {temp.ToString("C")}");
        
        Console.WriteLine("\n### Finished Testing UList ### \n\n---------------------");
    }
}