using System;
using System.Diagnostics;
using System.Linq;      
public class SortComparisonExample
{
   
    public static void SelectionSort(int[] arr)
    {
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

    // Bubble Sort 
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    
                }
            }
        }
    }

    // Function to print the array
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
        Console.Title = "Sorting Algorithm Comparison";

        // Original array (unchanged for both sorts)
        int[] original_array = { 64, 25, 12, 22, 11, 33, 55, 66, 88, 99, 100, 23, 11, 77, 458, 123, 63, 78, 99, 222, 123, 345, 678, 555, 666, 888, 777, 888 };

        Console.WriteLine("Original array: ");
        PrintArray(original_array);
        Console.WriteLine();

        
        Console.WriteLine("--- Selection Sort ---");
        // Selection Sort
        int[] arrayForSelectionSort = original_array.ToArray(); 

        Stopwatch stopwatchSelection = new Stopwatch();
        stopwatchSelection.Start();
        SelectionSort(arrayForSelectionSort);
        stopwatchSelection.Stop();

        Console.Write("Sorted by Selection Sort: ");
        PrintArray(arrayForSelectionSort);
        Console.WriteLine($"Time taken by SelectionSort: {stopwatchSelection.Elapsed.TotalMilliseconds} milliseconds");
        Console.WriteLine();

        // --- Bubble Sort ---
        Console.WriteLine("--- Bubble Sort ---");
        
        int[] arrayForBubbleSort = original_array.ToArray(); // .ToArray() a copy

        Stopwatch stopwatchBubble = new Stopwatch();
        stopwatchBubble.Start();
        BubbleSort(arrayForBubbleSort);
        stopwatchBubble.Stop();

        Console.Write("Sorted by Bubble Sort: ");
        PrintArray(arrayForBubbleSort);
        Console.WriteLine($"Time taken by BubbleSort: {stopwatchBubble.Elapsed.TotalMilliseconds} milliseconds");
        Console.WriteLine();

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}