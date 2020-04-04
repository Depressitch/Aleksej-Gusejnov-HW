using System;

public static class Program
{
    public static void Main()
    {
        Console.Write("Input array's length: ");
        int[] arr = new int[Parse.IntValue("array's length")];
        arr = Array.GetRand(arr, -20, 20);
        Console.WriteLine("Your unsorted array: ");
        Array.Output(arr);
        Console.WriteLine("\n");
        Array.QuickSort(arr);
        Console.WriteLine("Your sorted array: ");
        Array.Output(arr);
        Console.WriteLine("\n");
        AddCmd.Repeat('r');
    }
}
