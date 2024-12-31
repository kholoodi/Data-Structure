class Node:
    def __init__(self, key):
        self.left = None
        self.right = None
        self.val = key

class BinarySearchTree:
    def __init__(self):
        self.root = None

    def insert(self, key):
        if self.root is None:
            self.root = Node(key)
        else:
            self._insert(self.root, key)
    
    def _insert(self, node, key):
        if key < node.val:
            if node.left is None:
                node.left = Node(key)
            else:
                self._insert(node.left, key)
        else:
            if node.right is None:
                node.right = Node(key)
            else:
                self._insert(node.right, key)
    
 
    def inorder(self):
        self._inorder(self.root)
    
    def _inorder(self, node):
        if node:
            self._inorder(node.left)
            print(node.val, end=" ")
            self._inorder(node.right)

    def preorder(self):
        self._preorder(self.root)
    
    def _preorder(self, node):
        if node:
            print(node.val, end=" ")
            self._preorder(node.left)
            self._preorder(node.right)

    def postorder(self):
        self._postorder(self.root)
    
    def _postorder(self, node):
        if node:
            self._postorder(node.left)
            self._postorder(node.right)
            print(node.val, end=" ")


    
    def _min_value_node(self, node):
        current = node
        while current.left is not None:
            current = current.left
        return current

# Example usage:
bst = BinarySearchTree()
bst.insert(10)
bst.insert(3)
bst.insert(9)
bst.insert(5)
bst.insert(11)
bst.insert(15)
bst.insert(20)


print("In-order traversal of the given tree")
bst.inorder()

print("\n\nPre-order traversal of the given tree")
bst.preorder()

print("\n\nPost-order traversal of the given tree")
bst.postorder()

''''
 Output:

In-order traversal of the given tree
3 5 9 10 11 15 20 

Pre-order traversal of the given tree
10 3 9 5 11 15 20 

Post-order traversal of the given tree
5 9 3 20 15 11 10 
'''