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
    
    def search(self, key):
        return self._search(self.root, key)
    
    def _search(self, node, key):
        if node is None or node.val == key:
            return node
        if key < node.val:
            return self._search(node.left, key)
        return self._search(node.right, key)
    
    def inorder(self):
        self._inorder(self.root)
    
    def _inorder(self, node):
        if node:
            self._inorder(node.left)
            print(node.val, end=" ")
            self._inorder(node.right)
            
    def _min_value_node(self, node):
      current = node
      while current.left is not None:
        current = current.left
      return current 
     
    def delete(self, key):
        self.root = self._delete(self.root, key)
    
    def _delete(self, node, key):
        if node is None:
            return node
        
        if key < node.val:
            node.left = self._delete(node.left, key)
        elif key > node.val:
            node.right = self._delete(node.right, key)
        else:
            if node.left is None:
                return node.right
            elif node.right is None:
                return node.left
            
            temp = self._min_value_node(node.right)
            node.val = temp.val
            node.right = self._delete(node.right, temp.val)
        
        return node
    

# Example usage:
bst = BinarySearchTree()
bst.insert(50)
bst.insert(30)
bst.insert(20)
bst.insert(40)
bst.insert(70)
bst.insert(60)
bst.insert(80)

print("Inorder traversal of the given tree")
bst.inorder()

print("\n\nDelete 20")
bst.delete(20)
print("Inorder traversal of the modified tree")
bst.inorder()

print("\n\nDelete 30")
bst.delete(30)
print("Inorder traversal of the modified tree")
bst.inorder()

print("\n\nDelete 50")
bst.delete(50)
print("Inorder traversal of the modified tree")
bst.inorder()
'''
Output:

Inorder traversal of the given tree
20 30 40 50 60 70 80 

Delete 20
Inorder traversal of the modified tree
30 40 50 60 70 80 

Delete 30
Inorder traversal of the modified tree
40 50 60 70 80 

Delete 50
Inorder traversal of the modified tree
40 60 70 80 
'''