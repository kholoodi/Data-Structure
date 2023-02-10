using  SinglyLinkedList ;
namespace SinglyLinkedList 
{
class node1{
    private object data;
    private node1 next;
    public node1(){
        data = null;
        next = null;
    
    }
    public node1 (object O){
        data = O;
        next = null;
    }
    public node1 (object O, node1 N){
        data = O;
        next = N;
    }
    //method for return the index of the next node 
    public node1 getNextNode()
    { return next;}
    //method for return the value of the next node 
    public object getData()
    { return data;}
    public void SetNextNode(node1 n){
        next = n;
    }
    public void SetData(object o){
        data = o;
    }
}
}