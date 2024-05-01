using System.Collections;

namespace UtilityLib.UDataTypes.UList;

public partial struct UList<T>
{
    private T[] _content;

    public T this[int index]
    {
        get => (T) _content[index];
        set => _content[index] = value;
    }
    
    public UList() => _content = new T[0];

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

    public int Size => _content.Length;
    public int Length => _content.Length;
    public int Count => _content.Length;

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
}