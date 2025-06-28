namespace UtilityLib.UData.ULinkedLists;

public interface IULinkedList<T>
{
    void AddFirst(T data);
    void AddLast(T data);
    void InsertAt(int index, T data);

    void RemoveFirst();
    void RemoveLast();
    void RemoveAt(int index);
    void Remove(T data);
    
    int Count { get; }
    T Get(int index);
    bool Contains(T data);
    int IndexOf(T data);

    void Reverse();
    IULinkedList<T> GetReverse();
}