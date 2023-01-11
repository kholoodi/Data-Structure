
using System.Collections.Generic;
using System.Collections;
using System;

    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            LinkedListNode<int> node0 = new LinkedListNode<int>(4);
            LinkedListNode<int> node1 = new LinkedListNode<int>(5);
            // Inserting methods 
            list.AddFirst(1);   
            list.AddFirst(node0);    
            list.AddLast(2);    
            list.AddBefore(node0, 3); 
            list.AddAfter(node0, node1);

            //Search methods 
            Console.WriteLine("----------"); 
            Console.WriteLine(list.Find(1).Value); 
            Console.WriteLine(list.FindLast(1).Value); 
            Console.WriteLine(list.Contains(1)); 
            
            //Math methods 
            Console.WriteLine("----------"); 
            Console.WriteLine(list.Sum());
            Console.WriteLine(list.Average());
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());
            Console.WriteLine("----------");

           //Deleteing methods the list is : 3 4 5 1 2 
           list.RemoveFirst();  //4 5 1 2 
           list.Remove(1); // 4 5 2 
           list.RemoveLast(); // 4 5 
           list.Clear();

            //print the LinkedList
            foreach (int i in list)
            {
                Console.Write(i +" ");
            }    
        }

    }


