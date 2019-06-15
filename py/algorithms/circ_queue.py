class CircularQueue:
    def __init__(self, size):
        self._size = size
        self._arr = [None for i in range(size)]
        self._front = self._rear = -1

    def is_full(self):
        return (self._rear + 1) % self._size == self._front

    def enqueue(self, val):
        if self.is_full():
            raise Exception('Queue is full')
        if self._front == -1:
            self._front = self._rear = 0
            self._arr[self._rear] = val
        else:
            self._rear = (self._rear + 1) % self._size
            self._arr[self._rear] = val
        return self

    def dequeue(self):
        if self._front == -1:
            raise Exception('Queue is empty')
        if self._rear == self._front:
            temp = self._arr[self._front]
            self._front = -1
            self._rear = -1
        else:
            temp = self._arr[self._front]
            self._front = (self._front + 1) % self._size
        return temp


    def print_me(self):
        print('front: ', self._front)
        print('rear: ', self._rear)
        print('elements: ')
        for ele in self._arr:
            print(ele)


if __name__ == "__main__":
    q = CircularQueue(4)
    q.enqueue(1).enqueue(2).enqueue(3)
    print(q.dequeue())
    print(q.dequeue())
    print(q.dequeue())
    q.enqueue(1).enqueue(2).enqueue(3)
    q.print_me()