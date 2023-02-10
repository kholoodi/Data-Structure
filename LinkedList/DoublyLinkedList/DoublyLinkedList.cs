using System.Dynamic;

namespace test {
    class DoublyLinkedList {
    protected node1 header;
    public DoublyLinkedList()
    {
        header = new node1("header");
    }
    private node1 Find(object item){
        node1 currentNode = new node1();
        currentNode = header;
        while( currentNode.Element != item)
        currentNode = currentNode.Flink;
        return currentNode;
    }
    public void Insert( object newItem , object after)
    {
        node1 current  =  new node1();
        node1 newNode = new node1();
        current = Find(after);
        newNode.Flink = current.Flink;
        newNode.Blink = current.Blink;
        current.Flink = newNode;
    }
    private node1 FindPrevious(){
        node1 current = header;
        while( !(current.Flink == null) && (current.Flink.Element != null))
            current = current.Flink;
        return current;
    }
    private node1 FindLast(){
        node1 current = new node1();
        current = header;
        while(! (current.Flink == null))
            current = current.Flink;
        return current;
    }
    public void Remove( object n){
        node1 p = Find(n);
        if(!(p.Flink == null))
        {
            p.Blink.Flink = p.Flink;
            p.Flink.Blink = p.Blink;
            p.Flink =null;
            p.Blink =null;
        }
    }
    public void PrintReverse(){
        node1 current = new node1();
        current = FindLast();
        while(!( current.Blink == null))
        {
            Console.WriteLine(current.Element);
            current = current.Blink;
        }
    }
    public void PrinList()
    {
        node1 current = new node1();
        current = header;
        while(!(current.Flink == null))
        {
            Console.WriteLine(current.Flink.Element);
            current = current.Flink;
        }
    }
    }
}