namespace UtilityLib.UExtensions;

public static class UIntExtensions
{
    public static bool IsOdd(this int var)
    {
        return var % 2 != 0;
    }
    
    public static bool IsEven(this int var)
    {
        return var % 2 == 0;
    }
    
    public static bool IsPrime(this int var)
    {
        if (var == 2)
            return true;

        if (var <= 1 || var.IsEven())
            return false;

        var boundary = (int)Math.Floor(Math.Sqrt(var));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (var % i == 0)
                return false;
        }

        return true;
    }
    
    public static bool IsFibonacci(this int var)
    {
        int a = 0;
        int b = 1;

        if (var <= 2)
        {
            return true;
        }

        while (var >= a)
        {
            int c = b;
            b = a + b;
            a = c;
            if (var == b)
            {
                return true;
            }
        }
        return false;
    }
}