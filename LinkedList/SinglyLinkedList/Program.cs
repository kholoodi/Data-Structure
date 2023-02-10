namespace SinglyLinkedList 
{
     class Program
    {
        static void Main(string[] args)
        {
           linkedList li = new linkedList();
           li.add(1);
           li.add(2);
           li.add(3);
           li.add(4);
           li.add(5);
           li.remove(4);
           li.PrintList();
          
           
        }
           
    }
}