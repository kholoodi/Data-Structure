class Node{
    public object Element; 
    public Node Linke;
    public Node(){
        Element = null;
        Linke = null;
    }
    public Node (object theElement){ 
        Element = theElement;
        Linke = null; 
    }
}