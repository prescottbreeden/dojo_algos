using System;
using SLL;
using SortAlgos;
using heaps;

namespace algos
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] bad = { 5, 42, 3, 0, 21, 10 };
      Sorts.QuickSort(bad, 0, bad.Length - 1);
      foreach (int num in bad)
        System.Console.WriteLine(num);

    }
  }
}
