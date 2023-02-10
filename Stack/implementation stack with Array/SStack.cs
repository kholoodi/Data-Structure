using System;

class SStack 
    {
        private int Max; 
        private int top;
        private object[] items;
        public SStack (int max)
        {
            Max = max;
            top = -1;
            items = new object[Max];
        }
        public SStack()
        {
            Max = 5;
            top = -1;
            items = new object[Max];
        }
        public SStack(object[] elemnts)
        {
            Max = elemnts.Length;
            top = -1;
            items = elemnts;
        }
        //check the stack is full
        public bool isFull()
        { 
            return ( top == Max -1);
        }
        //check the stack is empty
        public bool isEmpty()
        {
             return (top == -1);      
        }
        //push method for adding items to the stack
        public void Push( object data)
        {
            if (isFull())
                throw new Exception ("stack is full");
                    top++;
                items[top] = data; 
        }
        //pop method for removing items from the stack
        public object pop()
        {
            if(isEmpty())
                throw new Exception("Stack is empty");
            object data = items[top];
            top--;
            return data;
        }
        //peek method that return the value of last item adding to the stack 
        public object peek()
        {
            if (isEmpty()) 
                throw new Exception("Stack is empty");
                    
            else 
                return items[top];
         }
         //return the stack size
        public int size()
        {
            return items.Count();
        }
         //print the stack items 
        public void print()
        {
            if (isEmpty()) 
                throw new Exception("Stack is empty");
            else 
                {
                    for (int i = 0; i <= top; i++) 
                        Console.Write(" "+items[i]);
                    Console.WriteLine();
                }
        }
        
}

