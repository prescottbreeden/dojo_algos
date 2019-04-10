'''
-------------
    HEAPS
-------------

Proiority Queue:
    structure that implements a set S of elements, each of elements
    associated with a key

Operations:
    insert(S, x): insert element x into set S.
    max(S): return element of S with the largest key.
    extract_max(S): performs Max(S) and removes it from S.
    increase_key(S, x, k): increase the value of x's key to new value k.

  
Heap:
    - an array visualized as a nearly complete binary tree

e.g.
    [X, 16, 14, 10, 8, 7, 9, 3, 2, 4, 1]

                 (16)
               /      \
           (14)       (10)
           /  \      /  \
         (8)   (7)  (9) (3)
         / \    /
       (2) (4)(1)


                     root at 0   root at 1

    Root              0           1
    Parent           (i-1)/ 2     i/2
    Left child        i*2 + 1     i*2
    Right child       i*2 + 2     i*2 + 1

Max Heap: "The key of a node is >= the keys of its children"
Min Heap: "The key of a node is <= the keys of its children"

"What trivial process can now be performed on a Max Heap?"
"What trivial process can now be performed on a Min Heap?"


General:
    - rep invariant should always be maintained
    - max heap -> max heap ... bst -> bst ...

Max Heap Operations:

    build_max_heap(): produces a max heap from an unordered array
    max_heapify: 
        - correct a single violation of the max heap property in a subtree's root
        - assume that the trees rooted at left(i) and right(i) are max heaps

e.g.
    [X, 16, 4, 10, 14, 7, 9, 3, 2, 8, 1]

                 (16)
               /      \
            (4)       (10)
            /  \      /  \
         (14)  (7)  (9)  (3)
         / \    /
       (2) (8)(1)

    Elements [n/2+1 .. n] are all leaves
    Leaves are by definition max-heaps because they have no children

    Time Complexity:
        "Anytime you can convert a linear representation to a vertical one with
        levels and you can move level by level you will achieve O(log(n))"

'''

def max_heapify(arr, n, i):
    left = 2 * i + 1
    right = 2 * i + 2
    largest = i
    if left < n and arr[left] > arr[largest]:
        largest = left
    if right < n and arr[right] > arr[largest]:
        largest = right
    if largest != i:
        swap(arr, i, largest)
        max_heapify(arr, n, largest)

def build_max_heap(arr):
    n = len(arr)
    start = n//2
    for i in range(start, -1, -1):
        max_heapify(arr, n, i)

def swap(arr, idx1, idx2):
    arr[idx1], arr[idx2] = arr[idx2], arr[idx1]

def heap_sort(arr):
    n = len(arr)
    build_max_heap(arr)
    for i in range(n-1, 0, -1):
        swap(arr, i, 0)
        max_heapify(arr, i, 0)

max_heap = [16, 14, 10, 8, 7, 9, 3, 2, 4, 1]

heap = [1, 14, 10, 8, 17, 9, 13, 2, 4, 11]
heap_sort(heap)
print(heap)
