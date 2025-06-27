namespace UtilityLib.UData.ULinkedLists.USinglyLinkedList;

public partial struct USinglyLinkedList<T>
{
    public int Count { get; private set; } = 0;

    private void CountChanged()
    {
        USinglyLinkedListNode<T>? curNode = this.Head;
        int count = 0;

        while (curNode != null)
        {
            count++;
            this.Tail = curNode;
            curNode = curNode.Next;
        }

        Count = count;

        return;
    }

    public T Get(int index)
    {
        int curIndex = 0;

        foreach (var v in this)
        {
            if (index == curIndex)
            {
                return v;
            }
            
            curIndex++;
        }

        throw new IndexOutOfRangeException();
    }

    public bool Contains(T data)
    {
        foreach (var v in this)
        {
            if (v.Equals(data))
            {
                return true;
            }
        }

        return false;
    }

    public int IndexOf(T data)
    {
        int curIndex = 0;
        
        foreach (var v in this)
        {
            if (v.Equals(data))
            {
                return curIndex;
            }

            curIndex++;
        }

        return -1;
    }
}