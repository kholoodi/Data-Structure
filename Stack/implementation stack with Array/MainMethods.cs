using System.Collections;
using System;

   class Program{
        public static void Main( String [] args)
        {
           string[] names = {"Mona", "Reem", "Sara", "Nora"};
           SStack stackNames = new SStack(names);
            //Add itemes to stack 
            for(int i =0; i < names.Length; i++)
                stackNames.Push(names[i]);

            //print the stack items 
            stackNames.print(); 
            //trturn the top item 
            Console.WriteLine(stackNames.peek());
            //stack size 
            Console.WriteLine(stackNames.size());
            //remove the top 
            stackNames.pop();
            Console.WriteLine(stackNames.peek()) ; 
            stackNames.print(); 

            Console.ReadKey();     
        }
    }


