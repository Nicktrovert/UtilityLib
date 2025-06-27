namespace UtilityLib.UData.ULinkedLists.USinglyLinkedList;

public partial struct USinglyLinkedList<T>
{
    public USinglyLinkedList()
    {
        this.Head = null;
        this.Tail = null;
    }
    
    public USinglyLinkedList(USinglyLinkedListNode<T> head)
    {
        this.Head = head;
        
        CountChanged();
    }

    public USinglyLinkedList(T data)
    {
        this.Head = new USinglyLinkedListNode<T>(data);
        
        CountChanged();
    }
}