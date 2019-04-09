def bubble_sort(arr):
    sorted = False
    while (not sorted):
        touched = False
        for i in range(len(arr)-1):
            if arr[i] > arr[i+1]:
                touched = True
                swap(arr, i, i+1)
        if not touched:
            sorted = True


def selection_sort(arr):
    start = 0
    end = len(arr) - 1
    while (start < end):
        min = start
        for i in range(start, len(arr)):
            if arr[i] < arr[min]:
                min = i
        swap(arr, start, min)
        start += 1


def insertion_sort(arr):
    for i in range(1, len(arr)):
        test = i
        while arr[test] < arr[test-1] and test > 0:
            swap(arr, test, test-1)
            test -= 1


def quick_sort(arr, low, high):
    if low < high:
        pivot = partition(arr, low, high)
        quick_sort(arr, low, pivot-1)
        quick_sort(arr, pivot + 1, high)

def partition(arr, low, high):
    pivot = arr[high]
    _swap = low - 1
    while low < high:
        if arr[low] <= pivot:
            _swap += 1
            swap(arr, _swap, low)
        low += 1
    _swap += 1
    swap(arr, _swap, high)
    return _swap
    

def merge_sort(arr):
    if len(arr) > 1:
        mid = int(len(arr) / 2)
        arr1 = arr[:mid]
        arr2 = arr[mid:]

        merge_sort(arr1)
        merge_sort(arr2)

        i = p1 = p2 = 0

        while p1 < len(arr1) and p2 < len(arr2):
            if arr1[p1] < arr2[p2]:
                arr[i] = arr1[p1]
                p1 += 1
            else:
                arr[i] = arr2[p2]
                p2 += 1
            i += 1

        while p1 < len(arr1):
            arr[i] = arr1[p1]
            p1 += 1
            i += 1

        while p2 < len(arr2):
            arr[i] = arr2[p2]
            p2 += 1
            i += 1


def swap(arr, idx1, idx2):
    temp = arr[idx1]
    arr[idx1] = arr[idx2]
    arr[idx2] = temp

