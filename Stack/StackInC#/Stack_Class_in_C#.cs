using System.Collections;
using System;
   class Program{
    
        public static void Main( String [] args)
        {
           Stack<string> s =new Stack<string>();
           s.Push("Mona");
           s.Push("Reem");
           s.Push("Sara");
           s.Push("Nora");

            //print the stack items 
            foreach (string n in s)
                 Console.Write(n + " ");
            Console.WriteLine();
            Console.WriteLine(s.Peek());
           
            //remove the top 
            s.Pop(); 
            foreach (string n in s)
                 Console.Write(n + " ");
            Console.ReadKey();     
        }
    }


