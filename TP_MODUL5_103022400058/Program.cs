using System;

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

        DataGeneric<string> dataNIM = new DataGeneric<string>("103022400058");
        dataNIM.PrintData();
    }
}