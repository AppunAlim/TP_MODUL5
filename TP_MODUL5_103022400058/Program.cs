using System;

public class HaloGeneric
{
    public void SapaUser<T>(T x)
    {
        Console.WriteLine("Halo user " + x);
    }
}

public class Program
{
    public static void Main()
    {
        HaloGeneric objekHalo = new HaloGeneric();
        objekHalo.SapaUser<string>("affan");
    }
}