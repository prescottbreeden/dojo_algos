def print_keys_values(obj):
    for k, v in obj.items():
        print(k, v)


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
        def add_helper(node=self.head):
            if not node.next:
                node.next = Node(value)
                return self
            return add_helper(node.next) 

        if not self.head:
            self.head = Node(value)
            return self
        add_helper()
        return self
    
    def removeFront(self):
        if not self.head:
            return self
        node = self.head
        self.head = self.head.next
        return node.value
         
    def removeBack(self):
        if not self.head:
            return self
        runner = self.head
        while(runner.next.next):
            runner = runner.next
        pop = runner.next.value
        runner.next = None
        return pop

    def removeBack_recursive(self):
        def remove_helper(node=self.head):
            if not node.next.next:
                pop = node.next 
                node.next = None
                return pop
            return remove_helper(node.next)
        if not self.head:
            return self
        if not self.head.next:
            self.head = None
            return node.value
        return remove_helper()

    def testNodes(self):
        def print_helper(node=self.head):
            if not node:
                return self
            print(node.value)
            return print_helper(node.next)
        return print_helper()


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

    def readMe(self):
        self.stack.testNodes()



if __name__ == "__main__":
    # test code here