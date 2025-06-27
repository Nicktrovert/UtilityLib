using System.Collections;

namespace UtilityLib.UData.UList;

public partial struct UList<T> : IEnumerable
{
    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) GetEnumerator();
    public UListEnum<T> GetEnumerator() => new UListEnum<T>(_content);
}

public struct UListEnum<T> : IEnumerator
{
    private T[] _objects;

    private int position = -1;

    public UListEnum(T[] list) => _objects = list;
    
    public bool MoveNext()
    {
        position++;
        return (position < _objects.Length);
    }

    public void Reset() => position = -1;

    object IEnumerator.Current => Current;

    public T Current
    {
        get
        {
            try
            {
                return _objects[position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
}