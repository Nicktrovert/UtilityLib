using System.Runtime.InteropServices;

namespace UtilityLib.UData.ULinkedLists.USinglyLinkedList;

[StructLayout(LayoutKind.Auto)]
public partial struct USinglyLinkedList<T> : IULinkedList<T>
{
    public USinglyLinkedListNode<T>? Head { get; private set; } = null;

    public USinglyLinkedListNode<T>? Tail { get; private set; } = null;


    public override string ToString()
    {
        string returnString = "";
        int curIndex = 0;
        
        foreach (var v in this)
        {
            returnString += $"[| {curIndex}: {v.ToString()} |]";
            if (curIndex != 0 && curIndex != Count-1)
            {
                returnString += " -> ";
            }

            curIndex++;
        }
        
        return returnString;
    }
}