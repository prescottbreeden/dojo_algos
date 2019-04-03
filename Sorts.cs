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
            Swap(arr, i, i+1);
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
        int prev = i-1;
        if (arr[current] < arr[prev])
        {
          while (prev >= 0 && (arr[current] < arr[prev]))
          {
            Swap(arr, current, prev);
            current--;
            prev--;
          } 
        }
      }
    }

  }
}
