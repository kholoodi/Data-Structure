using System;
namespace SinglyLinkedList 
{
class linkedList
{
    private node1 Header; 
    // is the list empty 
    public bool isempty(){
        return (Header == null);
    }
    //Method GetLength() for return length of linkedList 
     public int GetLength()
     {
        int count = 0;
        node1 currentNode = Header;
        while(count != 0){
            currentNode = currentNode.getNextNode();
            count++;
        }
        return count;
     }
    //Method for add a new item  
    public bool add (object newentery){
        return Insert( GetLength() + 1, newentery);
    }
     // Adding the item to the LinkedList with a specific position
     public bool Insert (int position , object newentery) {
        node1 temp = Header;
        if(position >= 1){
            node1 newnode = new node1(newentery);
            if(isempty() || position == 1)
            {
                newnode.SetNextNode(temp);
                Header = newnode;
                return true;
            }
            else
             {
                for(int i = 0; i < (position -1) && (temp != null); i++)
                {
                    temp = temp.getNextNode();
                }
                if (temp == null){
                    return false;
                }
                newnode.SetNextNode(temp.getNextNode());
                temp.SetNextNode(newnode);
                return true;
            }// end else
        }//end if 
        else
        {
            return false;
        }
        
     }// end add method
     
     //Method for removing items 
     public void clear(){
        Header = null;
     }
     //Method for return position of the specific item 
     public object getEntery( int position){
        if (isempty() || position < 1)
        {
            return false;
        }
        node1 currentNode = Header;
        object tempobj =  Header.getData();
        for( int i = 0; i < position && tempobj != null ; i++)
        {
            currentNode = currentNode.getNextNode();
        }
        if (currentNode == null){
            return null;
        }
        return currentNode.getData();
     }
     // Method check if item in LinkedList  
     public bool contains( object entry)
     {
        node1 currentNode = Header ;
        while( currentNode !=  null)
        {
            if( currentNode.getData()== entry)
            { return true; }
            currentNode = currentNode.getNextNode();
        }
        return false;
     }
     //Method for replacing item with ather one in the LinkedList 
     public bool replace( int position, object entry)
     {
        if( isempty() || position < 1)
        {
            return false;
        }
        node1 currentNode = Header;
        for ( int i = 0; i < position; i++)
        {
            currentNode = currentNode.getNextNode();
        }
        currentNode.SetData(entry);
        return true;
     }
    //Method for reomving specific item from LinkedList 
    public object remove (int position)
    {
        object temp = null;
        if ( isempty() || position < 1)
        {
            return false;
        }
        node1 currentNode = Header;
        //if the we want removing the first item 
        if( position == 1)
        {
            temp = currentNode.getData();
            Header = currentNode.getNextNode();
        }
        // reomving item from the linkedlist 
        for ( int i = 0; i < position -1 && currentNode != null ; i++)
        {
            currentNode = currentNode.getNextNode();
            if( currentNode == null)
            {
                return null;
            }
            //A setp for saving the value of reomving item 
            temp = currentNode.getData();
            // removing step
            currentNode.SetNextNode(currentNode.getNextNode().getNextNode());
        }
        return temp;
    }
    //Display the LinkedList 
    public void PrintList (){
        node1 current = new node1();
        current = Header;
        while(!(current.getNextNode() == null))
        {
            Console.Write(current.getData() + " ");
            current = current.getNextNode();
        }
    }



}
}