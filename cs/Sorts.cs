using System;

namespace SortAlgos
{
  class Sorts
  {
    /// <summary>
    /// Swaps two values inside of an array
    /// </summary>
    /// <param name="arr">ref to an integer array</param>
    /// <param name="idx1">first index to be swapped</param>
    /// <param name="idx2">second index to be swapped</param>
    public static void Swap(int[] arr, int idx1, int idx2)
    {
      int temp;
      temp = arr[idx1];
      arr[idx1] = arr[idx2];
      arr[idx2] = temp;
    }


    /// <summary>
    /// Takes an array and sorts it by pairwise swapping each
    /// time an element is greater than the element following it in the array.
    /// </summary>
    /// <param name="arr">ref to an integer array</param>
    /// <remarks>Time Complexity: O(n) --> O(n^2) || Average: O(n^2)</remarks>
    public static void Bubble(int[] arr)
    {
      bool sorted = false;
      int i;
      while (!sorted)
      {
        bool touched = false;
        for (i = 0; i < arr.Length - 1; i++)
        {
          if (arr[i] > arr[i + 1])
          {
            touched = true;
            Swap(arr, i, i + 1);
          }
        }
        if (!touched)
          sorted = true;
      }
    }


    /// <summary>
    /// Takes an array and sorts it by finding the lowest
    /// value element, moving it to the front of the array, and then 
    /// repeating the task excluding all previously sorted elements.
    /// </summary>
    /// <param name="arr">ref to an integer array</param>
    /// <remarks>Time Complexity: O(n^2) || Average: O(n^2)</remarks>
    public static void Selection(int[] arr)
    {
      int start = 0;
      int end = arr.Length;
      int min;
      int i;

      while (start < end)
      {
        min = start;
        for (i = start; i < end; i++)
        {
          if (arr[i] < arr[min])
            min = i;
        }
        Swap(arr, min, start);
        start++;
      }
    }


    /// <summary>
    /// Takes an array and sorts it by moving each element earlier
    /// in the array until it is no longer greater than the element to its
    /// left.
    /// </summary>
    /// <param name="arr">ref to an integer array</param>
    /// <remarks>Time Complexity: O(n) --> O(n^2) || Average: O(n^2)</remarks>
    public static void Insertion(int[] arr)
    {
      int i;
      for (i = 1; i < arr.Length; i++)
      {
        int current = i;
        int prev = i - 1;
        while (prev >= 0 && (arr[current] < arr[prev]))
        {
          Swap(arr, current, prev);
          current--;
          prev--;
        }
      }
    }


    /// <summary>
    /// Recursive function that takes an array and sorts it by breaking the array 
    /// into smaller arrays and then reassembles them back together sorting each 
    /// element into order.
    /// </summary>
    /// <param name="arr">ref to an integer array</param>
    /// <param name="start">starting index</param>
    /// <param name="end">last index</param>
    /// <remarks>Time Complexity: O(n(log(n)))</remarks>
    public static void MergeSort(int[] arr, int start, int end)
    {
      if (start < end)
      {
        int mid = (start + end) / 2;
        MergeSort(arr, start, mid);
        MergeSort(arr, mid + 1, end);
        Merge(arr, start, mid, end);
      }
    }


    /// <summary>
    /// Helper function for MergeSort.
    /// </summary>
    /// <param name="arr">ref to an integer array</param>
    /// <param name="start">starting index</param>
    /// <param name="mid">middle index</param>
    /// <param name="end">last index</param>
    private static void Merge(int[] arr, int start, int mid, int end)
    {
      int i;
      int sizeLeft = mid - start + 1;
      int sizeRight = end - mid;
      int[] arr1 = new int[sizeLeft];
      int[] arr2 = new int[sizeRight];

      for (i = 0; i < sizeLeft; i++)
        arr1[i] = arr[start + i];

      for (i = 0; i < sizeRight; i++)
        arr2[i] = arr[mid + 1 + i];

      i = start;
      int p1 = 0;
      int p2 = 0;

      while ((p1 < arr1.Length) && (p2 < arr2.Length))
      {
        if (arr1[p1] <= arr2[p2])
        {
          arr[i] = arr1[p1];
          p1++;
        }
        else
        {
          arr[i] = arr2[p2];
          p2++;
        }
        i++;
      }

      while (p1 < arr1.Length)
      {
        arr[i] = arr1[p1];
        p1++;
        i++;
      }

      while (p2 < arr2.Length)
      {
        arr[i] = arr2[p2];
        p2++;
        i++;
      }
    }


    /// <summary>
    /// Recursive function that takes an array and sorts it by swapping elements
    /// around a pivot element.
    /// </summary>
    /// <param name="arr">ref to an integer array</param>
    /// <param name="low">starting index</param>
    /// <param name="high">last index</param>
    /// <remarks>Time Complexity: O(n^2) --> O(n(log(n)))</remarks>
    public static void QuickSort(int[] arr, int low, int high)
    {
      if (low < high)
      {
        int pivot = Partition(arr, low, high);
        QuickSort(arr, low, pivot-1);
        QuickSort(arr, pivot+1, high);
      }      
    }

    /// <summary>
    /// Helper function for QuickSort
    /// </summary>
    /// <param name="arr">ref to an integer array</param>
    /// <param name="low">starting index</param>
    /// <param name="high">last index</param>
    /// <remarks>Time Complexity: O(n^2) --> O(n(log(n)))</remarks>
    static int Partition(int[] arr, int low, int high)
    {
      int pivot = arr[high];
      int swapIdx = low-1;

      while(low < high)
      {
        if (arr[low] <= pivot)
        {
          swapIdx++;
          Swap(arr, swapIdx, low);
        }
        low++;
      }
      swapIdx++;
      Swap(arr, swapIdx, high);
      return swapIdx;
    }

  }
}
