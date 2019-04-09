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

def get_parent(heap, val):
    idx = heap.index(val)
    parent = int((idx) / 2)
    print(heap[parent])
    return parent

def get_left(heap, val):
    idx = heap.index(val)
    left = int(2 * idx)
    print(heap[left])
    return left

def get_right(heap, val):
    idx = heap.index(val)
    right = int(2 * idx + 1)
    print(heap[right])
    return right

def max_heapify(arr, i):
    left = 2 * i
    right = 2 * i + 1
    largest = i
    if left < len(arr) and arr[left] > arr[largest]:
        largest = left
    if right < len(arr) and arr[right] > arr[largest]:
        largest = right
    if largest != i:
        swap(arr, i, largest)
        max_heapify(arr, largest)

def build_max_heap(arr):
    start = len(arr)//2
    for i in range(start, 0, -1):
        max_heapify(arr, i)

def swap(arr, idx1, idx2):
    arr[idx1], arr[idx2] = arr[idx2], arr[idx1]


max_heap = [0, 16, 14, 10, 8, 7, 9, 3, 2, 4, 1]
# get_parent(max_heap, 9)
# get_left(max_heap, 10)
# get_right(max_heap, 14)

heap = [0, 1, 14, 10, 8, 17, 9, 13, 2, 4, 11]
build_max_heap(heap)
print(heap)