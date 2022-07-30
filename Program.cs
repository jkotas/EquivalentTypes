using System;
using System.Reflection;
using System.Runtime.InteropServices;

public class My
{
    static void Main()
    {
        Type otherEquivalentValueType = Type.GetType("EquivalentValueType, mylib");
        Console.WriteLine(typeof(EquivalentValueType).IsEquivalentTo(typeof(EquivalentValueType)));

        var mi = typeof(My).GetMethod("MyMethod");
        object[] args = new object[1] { Activator.CreateInstance(otherEquivalentValueType) };
        mi.Invoke(null, args);
    }

    public static void MyMethod(EquivalentValueType v)
    {
    }
}
