namespace UtilityLib.UData.ULinkedLists.USinglyLinkedList;

public class USinglyLinkedListNode<T>
{
    public T Data { get; set; }
    public USinglyLinkedListNode<T>? Next { get; set; }

    public USinglyLinkedListNode(T data)
    {
        this.Data = data;
        Next = null;
    }
}