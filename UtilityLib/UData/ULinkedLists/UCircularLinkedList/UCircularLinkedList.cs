namespace UtilityLib.UData.ULinkedLists.UCircularLinkedList;

public partial struct UCircularLinkedList<T> : IULinkedList<T>
{
    public UCircularLinkedList()
    {
        
    }
    
    public void AddFirst(T data)
    {
        throw new NotImplementedException();
    }

    public void AddLast(T data)
    {
        throw new NotImplementedException();
    }

    public void InsertAt(int index, T data)
    {
        throw new NotImplementedException();
    }

    public void RemoveFirst()
    {
        throw new NotImplementedException();
    }

    public void RemoveLast()
    {
        throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
        throw new NotImplementedException();
    }

    public void Remove(T data)
    {
        throw new NotImplementedException();
    }

    public int Count { get; } = 0;
    
    public T Get(int index)
    {
        throw new NotImplementedException();
    }

    public bool Contains(T data)
    {
        throw new NotImplementedException();
    }

    public int IndexOf(T data)
    {
        throw new NotImplementedException();
    }

    public void Reverse()
    {
        throw new NotImplementedException();
    }

    public UCircularLinkedList<T> GetReverse()
    {
        throw new NotImplementedException();
    }

    IULinkedList<T> IULinkedList<T>.GetReverse() => (IULinkedList<T>) GetReverse();
}