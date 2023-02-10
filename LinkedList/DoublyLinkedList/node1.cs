namespace test {
public class node1{
    public object Element;
    public node1 Flink;
    public node1 Blink;
    public node1 ()
    {
        Element = null;
        Flink = null;
        Blink = null;
    }
    public node1 (object theElement )
    {
        Element = theElement;
        Flink = null;
        Blink = null;
    }
     
    
    }
}
