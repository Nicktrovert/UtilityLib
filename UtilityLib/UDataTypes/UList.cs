using System.Collections;

namespace UtilityLib.UDataTypes;

public class UList<T> : IEnumerable
{
    private T[] _content;

    public T this[int index]
    {
        get => (T) _content[index];
        set => _content[index] = value;
    }
    
    public UList()
    {
        _content = new T[0];
    }

    public UList(T[] objects)
    {
        _content = new T[objects.Length];
        for (int i = 0; i < objects.Length; i++)
        {
            _content[i] = objects[i];
        }
    }

    public void Add(T obj)
    {
        T[] newlist = new T[_content.Length + 1];
        for (int i = 0; i < newlist.Length; i++)
        {
            if (i < _content.Length)
            {
                newlist[i] = _content[i];
            }
            else
            {
                newlist[i] = obj;
            }
        }

        _content = newlist;
    }
    public void Add(T[] objs)
    {
        T[] newlist = new T[_content.Length + objs.Length];
        for (int i = 0; i < newlist.Length; i++)
        {
            if (i < _content.Length)
            {
                newlist[i] = _content[i];
            }
            else
            {
                newlist[i] = objs[i];
            }
        }

        _content = newlist;
    }

    public int Size
    {
        get => _content.Length;
        set => throw new NotSupportedException();
    }
    public int Length
    {
        get => _content.Length;
        set => throw new NotSupportedException();
    }
    public int Count
    {
        get => _content.Length;
        set => throw new NotSupportedException();
    }

    public int GetAmountOf(T obj)
    {
        int amount = 0;
        for (int i = 0; i < _content.Length; i++)
        {
            if (Equals(_content[i], obj))
            {
                amount++;
            }
        }
        
        return amount;
    }

    public void RemoveAt(int index)
    {
        if (index >= _content.Length)
        {
            throw new IndexOutOfRangeException();
        }

        T[] newlist = new T[_content.Length - 1];

        int ioffset = 0;

        for (int i = 0; i < _content.Length; i++)
        {
            if (i != index)
            {
                newlist[i - ioffset] = _content[i];
            }
            else
            {
                ioffset++;
            }
        }

        _content = newlist;
    }
    
    public void Remove(T obj, bool DeleteAll = false)
    {
        T[] newlist;
        bool ignoreComparison = false;
        if (DeleteAll)
        {
            newlist = new T[_content.Length - GetAmountOf(obj)];
        }
        else
        {
            newlist = new T[_content.Length - 1];   
        }
        for (int i = 0; i < newlist.Length; i++)
        {
            if (!Equals(_content[i], obj) || ignoreComparison)
            {
                newlist[i] = _content[i];
            }
            else
            {
                if (!DeleteAll)
                {
                    ignoreComparison = true;
                }
            }
        }

        _content = newlist;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return (IEnumerator) GetEnumerator();
    }
    
    public UListEnum<T> GetEnumerator()
    {
        return new UListEnum<T>(_content);
    }
}

public class UListEnum<T> : IEnumerator
{
    public T[] _objects;

    private int position = -1;

    public UListEnum(T[] list)
    {
        _objects = list;
    }
    
    public bool MoveNext()
    {
        position++;
        return (position < _objects.Length);
    }

    public void Reset()
    {
        position = -1;
    }

    object IEnumerator.Current
    {
        get
        {
            return Current;
        }
    }

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