using System;
class StackLinkedList{
    protected Node header;
    int count ;

    public StackLinkedList()
    {
        count = 0;
        header = new Node("header");
    }
    public void Push( object newItem){
        Node current = new Node();
        Node newNode = new Node(newItem);
        current = FindLast();
        newNode.Linke = current.Linke;
        current.Linke = newNode;
        count++;
    }
    private Node FindLast(){
        Node current = header;
        while (! (current.Linke == null))
            current = current.Linke;
            return current;
    }
    public object Pop(){
        Node current = FindBeforeLast();
        if ( current == null)
        {
            Console.WriteLine("Stack is empty");
            return null;
        }
        else{
            object data = current.Linke.Element;
            Remove();
            count--;
            return data;
        }   
    }
    private Node FindBeforeLast(){
        if (count > 1)
        {
            Node current = header;
            while (! (current.Linke.Linke == null))
                current = current.Linke;
                return current;
        }
        else if (count == 1)
            return header;
        else
            return null;
    }
    private void Remove(){
        Node p = FindBeforeLast();
        if (!(p.Linke == null))
        p.Linke = p.Linke.Linke;
    }
    public void PrintList()
    {
        Node current = new Node();
        current = header;
        while(!(current.Linke == null))
        {   Console.Write(current.Linke.Element + " ");
            current = current.Linke;
        }
        Console.WriteLine();
    }

}