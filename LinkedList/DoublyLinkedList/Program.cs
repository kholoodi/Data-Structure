namespace test {
public class Program {
    public static void Main(string[] args)
    {
        DoublyLinkedList li = new DoublyLinkedList();
        li.Insert("Mona","headr");
        li.Insert("Hassa","Mona");
        li.Insert("Rawan","Hassa");
        li.Insert("Rasha","Rawan");
        li.PrinList();
        Console.WriteLine("Reverse Order: ");
        li.PrintReverse();
        Console.ReadKey();

    }
}
}