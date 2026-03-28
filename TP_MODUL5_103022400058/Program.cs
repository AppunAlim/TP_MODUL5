using System;

public class HaloGeneric
{
    public void SapaUser<T>(T x)
    {
        Console.WriteLine("Halo user " + x);
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + this.data);
    }
}

public class Program
{
    public static void Main()
    {
        HaloGeneric objekHalo = new HaloGeneric();
        objekHalo.SapaUser<string>("affan");

        DataGeneric<string> dataNIM = new DataGeneric<string>("103022400058");
        dataNIM.PrintData();
    }
}