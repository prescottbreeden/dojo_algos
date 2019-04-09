arr = [5, 42, 3, 0, 21, 10];
console.log(`Quicksort: [${arr}]`);
QuickSort(arr, 0, arr.length-1);


function QuickSort(arr, low, high) {
  if (low < high) {
    pivot = Partition(arr, low, high);
    console.log('==============');
    console.log(`Quicksort: pivot = ${arr[pivot]}`);

    console.log(`Quicksort: [${arr[low]} .. ${arr[pivot-1]}]`);
    console.log('==============');
    QuickSort(arr, low, pivot - 1);
    console.log('==============');
    console.log(`Quicksort: [${arr[pivot+1]} .. ${arr[high]}]`);
    QuickSort(arr, pivot + 1, high);
  }
}

function Partition(arr, low, high) {
  pivot = arr[high];
  swap = low - 1;
  console.log(`Pivot = ${pivot}`);
  while (low < high) {
    console.log(`--- if ${arr[low]} < ${pivot} ---`);
    if (arr[low] <= pivot) {
      swap++;
      console.log(`--- swap: arr[${swap}] with arr[${low}] ---`);
      Swap(arr, swap, low);
      console.log(`Array is now [${arr}]`);
    } else {
      console.log(`--- no swap ---`);
    }
    console.log(`... increment low: ${low}`)
    low++;
  }
  console.log('--- end while ---');
  swap++;
  console.log(`... swap = arr[${swap}] ...`);
  Swap(arr, swap, high);
  console.log(`Array is now [${arr}]`);
  console.log(`Returning new pivot: ${arr[swap]}`);
  return swap;
}

function Swap(arr, idx1, idx2) {
  console.log(`Swapping ${arr[idx1]} with ${arr[idx2]} `);
  temp = arr[idx1];
  arr[idx1] = arr[idx2];
  arr[idx2] = temp;
}