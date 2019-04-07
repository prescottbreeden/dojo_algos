'use strict'
module.exports = {
  bubbleSort,
  selectionSort,
  insertionSort,
  mergeSort,
  quickSort
}

// -------------------- //
//     Bubble Sort      //
// -------------------- //
function bubbleSort(arr) {
  let sorted = false;
  while (!sorted) {
    let touched = false;
    for (let i = 0; i < arr.length; i++) {
      if (arr[i] > arr[i+1]) {
        touched = true;
        _swap(arr, i, i+1);
      }
    }
    if (!touched) sorted = true;
  }
}


// -------------------- //
//    Selection Sort    //
// -------------------- //
function selectionSort(arr, start = 0, end = arr.length-1) {
  while (start < end) {
    let min = start;
    for (let i = start; i < arr.length; i++) {
      if (arr[i] < arr[min]) {
        min = i;
      }
    }
    _swap(arr, start, min);
    start++;
  }
}


// -------------------- //
//    Insertion Sort    //
// -------------------- //
function insertionSort(arr) {
  for(let i = 1; i < arr.length; i++) {
    let insert = i;
    while ((arr[insert] < arr[insert-1]) && insert > 0) {
      _swap(arr, insert, insert-1);
      insert--;
    }
  }
}


// -------------------- //
//      Merge Sort      //
// -------------------- //
function mergeSort(arr, start = 0, end = arr.length-1) {
  if (start < end) {
    let mid = parseInt((start + end) / 2);
    mergeSort(arr, start, mid);
    mergeSort(arr, mid+1, end);
    merge(arr, start, mid, end);
  }
}

function merge(arr, start, mid, end) {
  let arr1 = arr.slice(start, mid+1);
  let arr2 = arr.slice(mid+1, end+1);
  let p1 = 0; 
  let p2 = 0;
  let i = start;

  while ((p1 < arr1.length) && (p2 < arr2.length)) {
    if (arr1[p1] <= arr2[p2]) {
      arr[i] = arr1[p1];
      p1++;
    } else {
      arr[i] = arr2[p2];
      p2++;
    }
    i++;
  }

  while (p1 < arr1.length) {
    arr[i] = arr1[p1];
    p1++;
    i++;
  }

  while (p2 < arr2.length) {
    arr[i] = arr2[p2];
    p2++;
    i++;
  }
}


// -------------------- //
//      Quick Sort      //
// -------------------- //
function quickSort(arr, low = 0, high = arr.length-1) {
  if (low < high) {
    let pivot = partition(arr, low, high);
    quickSort(arr, low, pivot-1);
    quickSort(arr, pivot+1, high);
  }
}

function partition(arr, low, high) {
  let pivot = arr[high];
  let swap = low-1;
  while (low < high) {
    if (arr[low] <= pivot) {
      swap++;
      _swap(arr, swap, low);
    }
    low++;
  }
  swap++;
  _swap(arr, swap, high);
  return swap;
}


// -------------------- //
//      Swap Helper     //
// -------------------- //
function _swap(arr, idx1, idx2) {
  let temp = arr[idx1];
  arr[idx1] = arr[idx2];
  arr[idx2] = temp;
}