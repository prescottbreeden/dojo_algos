'''
    Binary Search Trees:

    for all nodes X:
        if Y is in the left subtree of X: key(Y) <= key(X)
        if Y is in the right subtree of X: key(Y) >= key(X)

    Insert:
        insert 49 --> make node with keyValue of 49
        insert 79 --> go to right of 49 and insert 79
        insert 46 --> go to left of 49 and insert 46 
        insert 41 --> go to left of 49, left of 46, attach left child


    if h is height of tree - insertion of node in O(h) time

    if multi-set: need some way to differentiate same value keys

    Standard BST operations in H time:
        insert():
        delete():
        find_min(): go left till leaf
        find_max(): go right till leaf
        next_layer(x): ?


    Augmented BSTs:
        new requirement: 
            Rank(t): how many planes are scheduled to land at times <= t @ O(h)

        subTree size added to node:
            whenever adding to tree, increment the subtree size to node attr


'''
class Node:
    def __init__(self, val):
        self.value = val
        self.parent = None
        self.right = None
        self.left = None

class BST:
    def __init__(self):
        self.root = None

    def add(self, val):
        pass

