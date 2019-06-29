# Question 1:
def standard_print_keys_values(obj):
    for k in obj:
        print(k)
        print(obj[k])


def python_print_keys_values(obj):
    for k, v in obj.items():
        print(k, v)


# Question 2:
def standard_reverse(arr):
    end = len(arr)
    half_length = end//2
    for i in range(half_length):
        temp = arr[i]
        arr[i] = arr[end-1-i]
        arr[end-1-i] = temp
    return arr


def python_reverse1(arr):
    for i in range(len(arr)//2):
        arr[i], arr[-1-i] = arr[-1-i], arr[i]
    return arr


def python_reverse2(arr):
    return arr[::-1]


# Question 3
#   Strings are immutable!


# Question 4
class Node():
    def __init__(self, value):
        self.value = value
        self.next = None


class SLL():
    def __init__(self):
        self.head = None

    def addFront(self, value):
        new_node = Node(value)
        new_node.next = self.head
        self.head = new_node
        return self

    def addBack(self, value):
        runner = self.head
        while (runner.next):
            runner = runner.next
        runner.next = Node(value)
        return self

    def removeFront(self):
        if not self.head:
            return self
        node = self.head
        self.head = self.head.next
        node.next = None
        return node
         
    def removeBack(self):
        if not self.head:
            return self
        runner = self.head
        while(runner.next.next):
            runner = runner.next
        pop = runner.next.value
        runner.next = None
        return pop


# Question 5:
class Stack():
    def __init__(self):
        self.stack = SLL()

    def push(self, val):
        self.stack.addFront(val)

    def pop(self):
        return self.stack.removeFront()

    def isEmpty(self):
        return self.stack.head is None

    def peek(self):
        return self.stack.head.value


# Question 6:
class Queue():
    def __init__(self):
        self.queue = []

    def enqueue(self, val):
        self.queue.append(val)
        return self
    
    def dequeue(self):
        return self.queue.pop(0)


class QueueStack():
    def __init__(self):
        self.s1 = Queue()
        self.s2 = Queue()

    def push(self, val):
        self._empty_s1()
        self.s1.enqueue(val)
        self._fill_s1()

    def pop(self):
        return self.s1.dequeue()

    def peek(self):
        return self.s1.queue[0]
        
    def _empty_s1(self):
        while(self.s1.queue):
            val = self.s1.dequeue()
            self.s2.enqueue(val)
            
    def _fill_s1(self):
        while(self.s2.queue):
            val = self.s2.dequeue()
            self.s1.enqueue(val)


# Question 7:
# Which Data Structure performs best for given task:
#   - Find Kth Element: Array
#   - Add to Front: SLL
#   - Add to Back: SLL
#   - Remove An Element: SLL


if __name__ == "__main__":
    # test code here