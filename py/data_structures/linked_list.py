class sll:
    def __init__(self):
        self.head = None

    def print_list(self):
        runner = self.head
        while runner:
            print(runner.value)
            runner = runner.next

    def add_to_front(self, val):
        if not self.head:
            self.head = node(val)
            return self
        temp = self.head
        self.head = node(val)
        self.head.next = temp
        return self

    def add_to_back(self, val):
        if not self.head:
            self.head = node(val)
            return self
        runner = self.head
        while runner.next:
            runner = runner.next
        runner.next = node(val)
        return self

    def remove_dupes(self):
        pass


class node:
    def __init__(self, val):
        self.value = val
        self.next = None

