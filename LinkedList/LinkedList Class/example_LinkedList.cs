public class TheLinkedList {
    public  TheNode header;
    public TheLinkedList(){
        header = new TheNode();
    }

    //To insert a new node after an existing node, we have to first find the “after” node.
    private TheNode Find(Object item){
        TheNode current = new TheNode();
        current = header;
        while(current.data != item){
            current = current.link;
        }
        return current; 
    }
    public void Insert ( object newItem , object after){
        TheNode current = new TheNode();
        TheNode newNode = new TheNode(newItem);
        current = Find(after);
        newNode.link = current.link;
        current.link = newNode;
        
    }
    //A method isempty() to determine the LinkedList is empty or not if the Linled list is empty return true 
	public bool isempty(){ 
		return (header == null);}
		

    // add the item to the LinkedList with a specific position 
public bool add ( int position,  object NewEntry) {
	TheNode temp = header;  // declaring the  variable with nod type 
// the position should be existing
	if( position >= 1){
		TheNode NewNode = new TheNode(NewEntry);
		if (isempty () || position == 1) {		// add the node
			 NewNode.SetNextNode(temp);
			header = new TheNode();
			return true;
		}// end nested if
        //else pass the other item 
		else {	
			for (int i = 0; i < (position -1) && temp != null; i++)
			{  temp = temp.getNextNode();	 }// end for
			if (temp == null) {  return false;   } 
				NewNode.SetNextNode(temp.getNextNode());
				temp.SetNextNode(NewNode);
				return true;
			}//end else
	}// end if 
	else { return false; }
}//end add 
    // for removing node we need to find the node before the node we want to remove
    private TheNode FindPrevious(object o){
        TheNode current = header;
        while(!(current.link == null) && (current.link.data != o))
            current = current.link;
        return current;
    }

    public void Remove (object o ){
        TheNode p = FindPrevious(o);
        if (!(p.link == null))
            p.link = p.link.link;
    }
    //Display the LinkedList 
    public void PrintList (){
        TheNode current = new TheNode();
        current = header;
        while(!(current.link == null))
        {
            Console.WriteLine(current.link.data);
            current = current.link;
        }
    }

    public int getLength(){ 
	 int count  = 0;
	 TheNode currentNode = header;
	while( currentNode != null){
		currentNode  = currentNode.getNextNode();
		count++;}//end while 
	return count;
	}//end getLength
public bool add (object newEntry ){
	 return add(getLength() +1 , newEntry );
	}//end add

public void clear() {
	 header = null;
     }	
}// end The_LinkedList class 