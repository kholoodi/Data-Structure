using System.Collections;
using System;

   //implementation stack by linkedlist 
   class Program{
    
        public static void Main( String [] args)
        {
           StackLinkedList slist =new StackLinkedList();
           slist.Push("Mona");
           slist.Push("Reem");
           slist.Push("Sara");
           slist.Push("Nora");

            //print the stack items 
            slist.PrintList(); 
            //remove the top 
            slist.Pop(); 
            slist.PrintList();
            Console.ReadKey();     
        }
    }


