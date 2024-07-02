using System;
using System.Collections.Generic;

public class Node
{
    public int Key;
    public List<Node> Children;

    public Node(int key)
    {
        Key = key;
        Children = new List<Node>();
    }
}

public class NaryTree
{
    public Node Root;

    public NaryTree()
    {
        Root = null;
    }
  //The method for inserting a node
    public void Insert(Node parent, int key)
    {
        if (parent != null)
        {
            parent.Children.Add(new Node(key));
        }
        else
        {
            if (Root == null)
            {
                Root = new Node(key);
            }
            else
            {
                Console.WriteLine("Parent is null and tree already has a root.");
            }
        }
    }
   //The searching method
    public Node Search(Node node, int key)
    {
        if (node == null)
            return null;

        if (node.Key == key)
            return node;

        foreach (var child in node.Children)
        {
            var result = Search(child, key);
            if (result != null)
                return result;
        }
        return null;
    }
    //The method for deleting a node
    public void Delete(Node parent, int key)
    {
        if (parent == null)
            return;

        for (int i = 0; i < parent.Children.Count; i++)
        {
            if (parent.Children[i].Key == key)
            {
                parent.Children.RemoveAt(i);
                return;
            }
            else
            {
                Delete(parent.Children[i], key);
            }
        }
    }
//The Preorder Traversal method
    public void PreorderTraversal(Node node)
    {
        if (node == null)
            return;

        Console.Write((char)node.Key + " ");
        foreach (var child in node.Children)
        {
            PreorderTraversal(child);
        }
    }
}

public class Program
{
    public static void Main()
    {
        NaryTree tree = new NaryTree();
        tree.Root = new Node('A');  //Creating the root node

        // Inserting children nodes to the root
        tree.Insert(tree.Root, 'B');
        tree.Insert(tree.Root, 'C');
        tree.Insert(tree.Root, 'D');
        
        //Inserting children nodes for the B node  
        Node node2 = tree.Search(tree.Root, 'B');
        if (node2 != null)
        {
            tree.Insert(node2, 'E');
            tree.Insert(node2, 'F');
        }
        
        // Inserting children nodes for the C node 
        Node node3 = tree.Search(tree.Root, 'C');
        if (node3 != null)
        {
            tree.Insert(node3, 'G');
            tree.Insert(node3, 'H');
            tree.Insert(node3, 'I');
        }
        //Inserting a node child for D node 
        Node node4 = tree.Search(tree.Root, 'D');
        if (node4 != null)
        {
            tree.Insert(node4, 'J');
        }
        
         //inserting a child to J node
        Node node5 = tree.Search(node4, 'J');
        if (node5 != null)
        {
            tree.Insert(node5, 'K');
        }
        Console.WriteLine("Pre-order traversal of the tree:");
        tree.PreorderTraversal(tree.Root);
        Console.WriteLine();

        Console.WriteLine("Delete node with key 'K':");
        tree.Delete(tree.Root, 'K');
        tree.PreorderTraversal(tree.Root);
        Console.WriteLine();
    }
}