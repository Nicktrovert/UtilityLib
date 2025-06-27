using System.Collections;

namespace UtilityLib.UData.ULinkedLists.USinglyLinkedList;

public partial struct USinglyLinkedList<T> : IEnumerable
{
    public Enumerator<T> GetEnumerator()
    {
        return new USinglyLinkedList.Enumerator<T>(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return (IEnumerator) GetEnumerator();
    }
}

public struct Enumerator<T> : IEnumerator
{
    private USinglyLinkedList<T> Enumerable;
    private USinglyLinkedListNode<T>? currentNode;

    public Enumerator(USinglyLinkedList<T> enumerable)
    {
        this.Enumerable = enumerable;
        currentNode = this.Enumerable.Head;
    }
    
    public bool MoveNext()
    {
        currentNode = currentNode.Next;
        return currentNode == null;
    }

    public void Reset()
    {
        currentNode = this.Enumerable.Head;
    }

    public T Current => currentNode.Data;

    object IEnumerator.Current => Current;
}