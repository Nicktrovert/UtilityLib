namespace UtilityLib.USort;

public static class USort
{
    public static IEnumerable<T> Sort<T>(this IEnumerable<T> enumerable, SortAlgorithm sortAlgorithm, Func<T, T, bool> compare)
    {
        switch (sortAlgorithm)
        {
            case SortAlgorithm.BubbleSort:
                return enumerable.BubbleSort(compare);
            case SortAlgorithm.SelectionSort:
                return enumerable.SelectionSort(compare);
            case SortAlgorithm.InsertionSort:
                return enumerable.InsertionSort(compare);
            default:
                return enumerable.BubbleSort(compare);
        }
    }
    
    public static IEnumerable<T> BubbleSort<T>(this IEnumerable<T> enumerable, Func<T, T, bool> compare)
    {
        var list = enumerable.ToList();

        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = 0; j < list.Count - i - 1; j++)
            {
                if (compare(list[j], list[j + 1]))
                {
                    (list[j], list[j + 1]) = (list[j + 1], list[j]);
                }
            }
        }

        return list;
    }

    public static IEnumerable<T> SelectionSort<T>(this IEnumerable<T> enumerable, Func<T, T, bool> compare)
    {
        var list = enumerable.ToList();

        for (int i = 0; i < list.Count - 1; i++)
        {
            int jSelection = i;
            for (int j = i+1; j < list.Count; j++)
            {
                if (compare(list[j], list[jSelection]))
                {
                    jSelection = j;
                }
            }

            if (jSelection != i)
            {
                (list[i], list[jSelection]) = (list[jSelection], list[i]);
            }
        }

        return list;
    }

    public static IEnumerable<T> InsertionSort<T>(this IEnumerable<T> enumerable, Func<T, T, bool> compare)
    {
        var list = enumerable.ToList();

        for (int i = 1; i < list.Count; i++)
        {
            T key = list[i];
            int j = i - 1;
            
            while (j >= 0 && compare(key, list[j]))
            {
                list[j + 1] = list[j];
                j--;
            }

            list[j + 1] = key;
        }

        return list;
    }
}