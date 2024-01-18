using System;

public class My
{
    static void Main()
    {
       MyLib.List = new EquivalentValueType[1];
       Console.WriteLine(typeof(EquivalentValueType[]) == MyLib.List.GetType());
    }
}
