using System.Reflection;

namespace UtilityLib.UExtensions;

public static class UObjectExtensions
{
    public static bool HasMethod(this object objectToCheck, string methodName)
    {
        var type = objectToCheck.GetType();
        return type.GetMethod(methodName) != null;
    }

    public static bool HasProperty(this object objectToCheck, string fieldName)
    {
        var type = objectToCheck.GetType();
        return type.GetProperty(fieldName) != null;
    }
    
    public static MethodInfo? TryGetMethod(this object objectToCheck, string methodName) => objectToCheck.HasMethod(methodName) ? objectToCheck.GetType().GetMethod(methodName) : null;

    public static Action<T>? TryGetAction<T>(this object objectToCheck, string methodName) => 
        objectToCheck.TryGetMethod(methodName) != null 
            ? (Action<T>) Delegate.CreateDelegate(typeof(Action<T>), objectToCheck, objectToCheck.TryGetMethod(methodName)) 
            : null;
    
    public static Action? TryGetAction(this object objectToCheck, string methodName) => 
        objectToCheck.TryGetMethod(methodName) != null 
            ? (Action) Delegate.CreateDelegate(typeof(Action), objectToCheck, objectToCheck.TryGetMethod(methodName)) 
            : null;

    public static string TryGetString(this object objectToCheck, string fieldName)
    {
        if (objectToCheck.HasProperty(fieldName))
            return objectToCheck.GetType().GetProperty(fieldName).GetValue(objectToCheck, null).ToString();
        return string.Empty;
    }

    public static short TryGetShort(this object objectToCheck, string fieldName)
    {
        if (objectToCheck.HasProperty(fieldName))
            return (short)(objectToCheck.TryGet<short>(fieldName));
        return default(short);
    }

    public static int TryGetInt(this object objectToCheck, string fieldName)
    {
        if (objectToCheck.HasProperty(fieldName))
            return Convert.ToInt32(objectToCheck.TryGet<int>(fieldName));
        return default(int);
    }

    public static long TryGetLong(this object objectToCheck, string fieldName)
    {
        if (objectToCheck.HasProperty(fieldName))
            return (long)(objectToCheck.TryGet<long>(fieldName));
        return default(long);
    }

    public static short TryGetInt16(this object objectToCheck, string fieldName)
    {
        if (objectToCheck.HasProperty(fieldName))
            return Convert.ToInt16(objectToCheck.TryGet<Int16>(fieldName));
        return default(Int16);
    }

    public static Int32 TryGetInt32(this object objectToCheck, string fieldName)
    {
        if (objectToCheck.HasProperty(fieldName))
            return Convert.ToInt32(objectToCheck.TryGet<Int32>(fieldName));
        return default(Int32);
    }

    public static Int64 TryGetInt64(this object objectToCheck, string fieldName)
    {
        if (objectToCheck.HasProperty(fieldName))
            return Convert.ToInt64(objectToCheck.TryGet<Int64>(fieldName));
        return default(Int64);
    }

    public static decimal TryGetDecimal(this object objectToCheck, string fieldName)
    {
        if (objectToCheck.HasProperty(fieldName))
            return Convert.ToDecimal(objectToCheck.TryGet<decimal>(fieldName));
        return default(decimal);
    }

    public static float TryGetFloat(this object objectToCheck, string fieldName)
    {
        if (objectToCheck.HasProperty(fieldName))
            return (float)(objectToCheck.TryGet<float>(fieldName));
        return default(float);
    }

    public static double TryGetDouble(this object objectToCheck, string fieldName)
    {
        if (objectToCheck.HasProperty(fieldName))
            return Convert.ToDouble(objectToCheck.TryGet<double>(fieldName));
        return default(double);
    }

    public static T? TryGet<T>(this object objectToCheck, string fieldName)
    {
        if (objectToCheck.HasProperty(fieldName))
            return (T)objectToCheck.GetType().GetProperty(fieldName).GetValue(objectToCheck, null);
        return default(T);
    }
}