using System;
using System.Diagnostics;



public class SelectionSortExample
{
    
    public static void SelectionSort(int[] arr)
    {
        Console.Title = "SelectionSort";
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int min_idx = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[min_idx])
                {
                    min_idx = j;
                }
            }
            
            int temp = arr[min_idx];
            arr[min_idx] = arr[i];
            arr[i] = temp;
        }
    }

    
    public static void PrintArray(int[] arr)
    {
        foreach (int x in arr)
        {
            Console.Write(x + " ");
        }
        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        
        int[] my_array = { 64, 25, 12, 22, 11 };

        Console.Write("Original array: ");
        PrintArray(my_array);

        
        Stopwatch stopwatch = new Stopwatch();

       
        stopwatch.Start();

        
        SelectionSort(my_array);

        
        stopwatch.Stop();

        Console.Write("Sorted array: ");
        PrintArray(my_array);

       
        Console.WriteLine($"Time taken by SelectionSort: {stopwatch.Elapsed.TotalMilliseconds} milliseconds");

        
        Console.ReadKey();
    }
}