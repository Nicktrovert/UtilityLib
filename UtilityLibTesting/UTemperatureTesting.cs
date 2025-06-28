using UtilityLib.UData.UTemperature;

namespace UtilityLibTesting;

public static class UTemperatureTesting
{
    public static void UTemperatureMain()
    {
        Console.WriteLine("### Started Testing UTemperature ### \n");

        UTemperature temp = new UTemperature(0);
        Console.WriteLine($"0°C to Kelvin (ToString): {temp.ToString("K")}");
        Console.WriteLine($"0°C to Fahrenheit (ToString): {temp.ToString("F")}");
        Console.WriteLine($"0°C to Celsius (ToString): {temp.ToString("C")}");
        
        Console.Write("\n");
        
        Console.WriteLine($"60°F to Celsius (Parse): {UTemperature.Parse("60°F")}");
        Console.WriteLine($"60°K to Celsius (Parse): {UTemperature.Parse("60°K")}");
        Console.WriteLine($"60°C to Celsius (Parse): {UTemperature.Parse("60°C")}");
        
        Console.Write("\n");
        
        Console.WriteLine($"{temp.ToString("F")} to Celsius (Both): {UTemperature.Parse(temp.ToString())}");
        Console.WriteLine($"{temp.ToString("K")} to Celsius (Both): {UTemperature.Parse(temp.ToString())}");
        Console.WriteLine($"{temp.ToString("C")} to Celsius (Both): {UTemperature.Parse(temp.ToString())}");
        
        Console.WriteLine("\n### Finished Testing UTemperature ### \n\n---------------------");
    }
}