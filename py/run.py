from algorithms.sorts import *
from data_structures.linked_list import *

arr = [6, 4, 31, 7, 22, 8, 42, 2, 1, 16]
quick_sort(arr, 0, len(arr) - 1)
print(arr)

chubby_unicorn = sll()
chubby_unicorn.add_to_front(0)
chubby_unicorn.add_to_back(1)
chubby_unicorn.add_to_back(2)
chubby_unicorn.add_to_back(3)
chubby_unicorn.add_to_back(4)
print("*" * 80)
chubby_unicorn.print_list()