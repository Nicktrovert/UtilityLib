namespace UtilityLib.UData.ULinkedLists.USinglyLinkedList;

public partial struct USinglyLinkedList<T>
{
    public void Reverse()
    {
        this = GetReverse();
    }

    public USinglyLinkedList<T> GetReverse()
    {
        USinglyLinkedList<T> reversedLinkedList = new USinglyLinkedList<T>();

        foreach (var v in this)
        {
            reversedLinkedList.AddFirst(v);
        }

        return reversedLinkedList;
    }

    public bool HasCycle()
    {
        var slow = this.Head;
        var fast = this.Head;

        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;

            if (slow == fast)
            {
                return true;
            }
        }

        return false;
    }

    public USinglyLinkedListNode<T>? FindMiddle(bool preferFirstMiddle = false)
    {
        if (Head == null)
        {
            return null;
        }

        int midIndex = preferFirstMiddle ? ((Count - 1) / 2) : (Count / 2);
        USinglyLinkedListNode<T> curNode = Head;

        for (int i = 0; i < midIndex; i++)
        {
            curNode = curNode.Next;
        }

        return curNode;
    }

    public T? GetMiddleValue(bool preferFirstMiddle = false)
    {
        USinglyLinkedListNode<T>? midNode = FindMiddle(preferFirstMiddle);
        return midNode != null ? midNode.Data : default(T);
    }
}