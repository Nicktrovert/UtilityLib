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

    public static int TryGetInt(this object objectToCheck, string fieldName)
    {
        if (objectToCheck.HasProperty(fieldName))
            return Convert.ToInt32(objectToCheck.GetType().GetProperty(fieldName).GetValue(objectToCheck, null));
        return 0;
    }

    public static decimal TryGetDecimal(this object objectToCheck, string fieldName)
    {
        if (objectToCheck.HasProperty(fieldName))
            return Convert.ToDecimal(objectToCheck.GetType().GetProperty(fieldName).GetValue(objectToCheck, null));
        return 0.0m;
    }

    public static float TryGetFloat(this object objectToCheck, string fieldName)
    {
        if (objectToCheck.HasProperty(fieldName))
            return (float)(objectToCheck.GetType().GetProperty(fieldName).GetValue(objectToCheck, null));
        return 0.0f;
    }

    public static double TryGetDouble(this object objectToCheck, string fieldName)
    {
        if (objectToCheck.HasProperty(fieldName))
            return Convert.ToDouble(objectToCheck.GetType().GetProperty(fieldName).GetValue(objectToCheck, null));
        return 0.0;
    }

    public static T TryGet<T>(this object objectToCheck, string fieldName)
    {
        if (objectToCheck.HasProperty(fieldName))
            return (T)(objectToCheck.GetType().GetProperty(fieldName).GetValue(objectToCheck, null));
        return default;
    }
}