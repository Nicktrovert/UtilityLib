﻿using UtilityLib.UMath;
using UtilityLib.UString;
using UtilityLib.UDataTypes.UVector;
using UtilityLib.UDataTypes.UList;

namespace UtilityLibTesting;

public static class UListTesting
{
    public static void UListMain()
    {
        Console.WriteLine("### Started Testing UList ### \n");
        
        UList<string> a = new UList<string>();
        a.Add("hi");
        Console.WriteLine(a[0]);
        Console.WriteLine(a.Length);
        a[0] = "Hello";
        Console.WriteLine(a[0]);
        a.Add("test");
        a.Add("test");
        Console.WriteLine(a[1]);
        Console.WriteLine(a.Length);
        a.Remove("test", true);
        Console.WriteLine(a.Length);
        
        Console.WriteLine("\n### Finished Testing UList ### \n\n---------------------");
    }
}