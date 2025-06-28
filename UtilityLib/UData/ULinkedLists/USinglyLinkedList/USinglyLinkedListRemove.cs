namespace UtilityLib.UData.ULinkedLists.USinglyLinkedList;

public partial struct USinglyLinkedList<T> : IULinkedList<T>
{
    public void RemoveFirst()
    {
        if (Count == 1)
        {
            this.Head = null;
            this.Tail = null;
        }
        else
        {
            this.Head = this.Head?.Next;
        }

        Count--;

        return;
    }

    public void RemoveLast()
    {
        if (Count < 1)
        {
            throw new IndexOutOfRangeException();
        }
        if (Count == 1)
        {
            RemoveFirst();
            return;
        }
        
        USinglyLinkedListNode<T>? curNode = this.Head;
        int curIndex = 0;

        while (curNode != null)
        {
            if (curIndex == Count-2)
            {
                curNode.Next = null;
                this.Tail = curNode;
                break;
            }

            curIndex++;
            curNode = curNode.Next;
        }

        Count--;
        
        return;
    }

    public void RemoveAt(int index)
    {
        if (index > Count - 1 || index < 0)
        {
            throw new IndexOutOfRangeException();
        }
        if (index == 0)
        {
            RemoveFirst();
            return;
        }

        if (index == Count - 1)
        {
            RemoveLast();
            return;
        }

        USinglyLinkedListNode<T>? curNode = this.Head;
        int curIndex = 0;

        while (curNode != null)
        {
            if (curIndex == index-1)
            {
                curNode.Next = curNode.Next?.Next;
                break;
            }

            curIndex++;
            curNode = curNode.Next;
        }

        Count--;
        
        return;
    }

    public void Remove(T data)
    {
        if (Head == null)
        {
            return;
        }

        if (Head.Data?.Equals(data) ?? false)
        {
            RemoveFirst();
            return;
        }

        USinglyLinkedListNode<T>? prev = this.Head;
        USinglyLinkedListNode<T>? curNode = this.Head.Next;

        while (curNode != null)
        {
            if (curNode.Data?.Equals(data) ?? false)
            {
                prev.Next = curNode.Next;

                if (curNode == Tail)
                {
                    Tail = prev;
                }

                Count--;
                return;
            }

            prev = curNode;
            curNode = curNode.Next;
        }
        
        return;
    }
}