namespace UtilityLib.UData.ULinkedLists.USinglyLinkedList;

public partial struct USinglyLinkedList<T> : IULinkedList<T>
{
    public void AddFirst(T data)
    { 
        if (Count == 0)
        {
            this.Head = new USinglyLinkedListNode<T>(data);
            this.Tail = this.Head;
        }
        else
        {
            USinglyLinkedListNode<T> oldHead = this.Head;
            this.Head = new USinglyLinkedListNode<T>(data);
            this.Head.Next = oldHead;
        }

        Count++;

        return;
    }

    public void AddLast(T data)
    {
        if (Count == 0)
        {
            this.Head = new USinglyLinkedListNode<T>(data);
            this.Tail = this.Head;
        }
        else
        {
            this.Tail.Next = new USinglyLinkedListNode<T>(data);
            this.Tail = this.Tail.Next;
        }

        Count++;

        return;
    }

    public void InsertAt(int index, T data)
    {
        if (index > Count || index < 0)
        {
            throw new IndexOutOfRangeException();
        }

        if (index == 0)
        {
            AddFirst(data);
            return;
        }

        if (index == Count)
        {
            AddLast(data);
            return;
        }

        USinglyLinkedListNode<T>? curNode = this.Head;
        int curIndex = 0;

        while (curNode != null)
        {
            if (curIndex == index-1)
            {
                USinglyLinkedListNode<T>? nextNode = curNode.Next;

                curNode.Next = new USinglyLinkedListNode<T>(data)
                {
                    Next = nextNode
                };
                break;
            }

            curIndex++;
            curNode = curNode.Next;
        }

        Count++;
        
        return;
    }
}