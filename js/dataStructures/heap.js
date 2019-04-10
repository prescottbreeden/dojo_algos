function heapSort(arr) {
  let n = arr.length;
  buildMaxHeap(arr);
  for (let i = n-1; i >= 0; i--) {
    swap(arr, i, 0);
    maxHeapify(arr, i, 0);
  }
}

function buildMaxHeap(arr) {
  let n = arr.length;
  start = Math.floor(n/2);
  for(let i = start; i >= 0; i--) {
    maxHeapify(arr, n, i);
  }
}

function maxHeapify(arr, n, i) {
  let largest = i;
  let left = 2 * i + 1;
  let right = 2 * i + 2;
  if (left < n && arr[left] > arr[largest]) {
    largest = left;
  }
  if (right < n && arr[right] > arr[largest]) {
    largest = right;
  }
  if (largest != i) {
    swap(arr, i, largest);
    maxHeapify(arr, n, largest);
  }
}

function swap(arr, idx1, idx2) {
  const temp = arr[idx1];
  arr[idx1] = arr[idx2];
  arr[idx2] = temp;
}

let heap = [8, 4, 5, 6, 7, 2, 3, 4, 6, 8, 9, 1, 6];
let heap2 = [1, 14, 10, 8, 17, 9, 13, 2, 4, 11];
heapSort(heap2);
console.log(heap2);
heapSort(heap);
console.log(heap);
