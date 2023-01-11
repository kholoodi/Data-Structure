public class TheNode {
	public object data;
	public TheNode link;
	public TheNode()
    {
		data = null;
		link = null;
	}
	public TheNode (object o){
		data = o;
		link = null;
	}
    public TheNode(object o , TheNode n)
    {
        data = o;
        link = n; 
    }
    // Node Methods 
    public TheNode getNextNode ()
    {
        return link; 
    }
    public object getData ()
    {
         return data;
    }
    public void SetNextNode ( TheNode n )
    {
         link = n;  
    }
    public void SetData (object d)
    { 
        data = d;
    }

}