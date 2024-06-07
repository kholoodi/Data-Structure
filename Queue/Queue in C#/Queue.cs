using System;
using System.Collections;
class program {
	public static void Main(String [] arge)
	{
        Queue<string> MyQueue = new Queue<string>();

        MyQueue.Enqueue("Monday");
        MyQueue.Enqueue("Tuesday");
        MyQueue.Enqueue("Wednesday");
        MyQueue.Enqueue("Thursday");
        MyQueue.Enqueue("Friday");
        MyQueue.Enqueue("Saturday");
        MyQueue.Enqueue("Sunday");
        Console.WriteLine(MyQueue.Peek());
        foreach (string i in MyQueue)
        Console.Write(i + " ");
        Console.WriteLine();
        MyQueue.Dequeue();
        Console.WriteLine(MyQueue.Peek());

         	
	}

    
}
