/*
 * =====================================================================================
 *
 *       Filename:  sorts.cpp
 *
 *    Description:  sorting algos
 *
 *        Version:  1.0
 *        Created:  04/20/2019 06:04:29 PM
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */
#include <stdlib.h>
#include <iostream>


void swap(int arr[], int idx1, int idx2)
{
  int temp;
  temp = arr[idx1];
  arr[idx1] = arr[idx2];
  arr[idx2] = temp;
}


void print_garb(int arr[], int len)
{
  int i = 0;

  for (i; i < len; i++)
  {
    printf("\n %i", arr[i]);
  }
}


void BubbleSort(int arr[], int len)
{
  int i;
  int j;
  for(i = 0; i < len - 1; i++)
  {
    for (j = 0; j < len - 1; j++)
    {
      if (arr[j] > arr[j+1])
      {
        swap(arr, j, j + 1);
      }
    }
  }
}


void SelectionSort(int arr[], int len)
{
  int i;
  int min;
  int start = 0;
  while (start < len-1)
  {
    for (i = start; i < len; i++)
    {
      if (arr[min] > arr[i])
      {
        min = i;
      }
    }
    swap(arr, start, min);
    start++;
  }
}


void InserstionSort(int arr[], int len)
{
  int i = 1;
  for (i; i < len; i++)
  {
    int current = i;
    int prev = i - 1;
    while (prev >= 0 && (arr[current] < arr[prev]))
    {
      swap(arr, current, prev);
      current--;
      prev--;
    }
  }
}


int main() 
{
  std::cout << "Hello World ";

  int array[] = { 5, 4, 3, 2, 1 };
  int len = sizeof(array)/sizeof(array[0]);
  BubbleSort(array, len);
  /* InserstionSort(array, len); */
  /* SelectionSort(array, len); */
  print_garb(array, len);

  return 0;
}
