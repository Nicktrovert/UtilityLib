using UtilityLib.UData.ULinkedLists.USinglyLinkedList;
using Xunit;
using Xunit.Abstractions;

namespace UtilityLib.Tests;

public class USinglyLinkedListTests
{
    private readonly ITestOutputHelper _output;

    public USinglyLinkedListTests(ITestOutputHelper output)
    {
        _output = output;
    }

    private void PrintList<T>(USinglyLinkedList<T> list)
    {
        var cur = list.Head;
        var items = new System.Text.StringBuilder();
        while (cur != null)
        {
            items.Append(cur.Data);
            if (cur.Next != null) items.Append(" -> ");
            cur = cur.Next;
        }
        _output.WriteLine($"List: {items}");
        _output.WriteLine($"Count: {list.Count}, Head: {list.Head.Data}, Tail: {list.Tail.Data}");
    }

    [Fact]
    public void AddFirst_ShouldSetHeadAndCount()
    {
        var list = new USinglyLinkedList<int>();
        list.AddFirst(10);

        Assert.NotNull(list.Head);
        Assert.Equal(10, list.Head.Data);
        Assert.Equal(1, list.Count);
        Assert.Equal(list.Head, list.Tail);

        PrintList(list);
    }

    [Fact]
    public void AddLast_ShouldAppendAndUpdateTail()
    {
        var list = new USinglyLinkedList<int>();
        list.AddLast(10);
        list.AddLast(20);

        Assert.Equal(2, list.Count);
        Assert.Equal(10, list.Head.Data);
        Assert.Equal(20, list.Tail.Data);

        PrintList(list);
    }

    [Fact]
    public void InsertAt_ShouldInsertCorrectly()
    {
        var list = new USinglyLinkedList<int>();
        list.AddLast(1);
        list.AddLast(3);
        list.InsertAt(1, 2);  // Insert '2' between 1 and 3

        Assert.Equal(3, list.Count);

        // Verify the sequence is 1 -> 2 -> 3
        Assert.Equal(1, list.Head.Data);
        Assert.Equal(2, list.Head.Next.Data);
        Assert.Equal(3, list.Tail.Data);

        PrintList(list);
    }

    [Fact]
    public void RemoveFirst_ShouldUpdateHeadAndCount()
    {
        var list = new USinglyLinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.RemoveFirst();

        Assert.Equal(1, list.Count);
        Assert.Equal(2, list.Head.Data);
        Assert.Equal(list.Head, list.Tail);

        PrintList(list);
    }

    [Fact]
    public void RemoveLast_ShouldUpdateTailAndCount()
    {
        var list = new USinglyLinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.RemoveLast();

        Assert.Equal(1, list.Count);
        Assert.Equal(1, list.Head.Data);
        Assert.Equal(list.Head, list.Tail);

        PrintList(list);
    }

    [Fact]
    public void RemoveAt_ShouldRemoveCorrectNode()
    {
        var list = new USinglyLinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);

        list.RemoveAt(1); // Remove '2'

        Assert.Equal(2, list.Count);
        Assert.Equal(1, list.Head.Data);
        Assert.Equal(3, list.Tail.Data);
        Assert.Equal(3, list.Head.Next.Data);

        PrintList(list);
    }

    [Fact]
    public void Remove_Value_ShouldRemoveFirstMatching()
    {
        var list = new USinglyLinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);
        list.AddLast(3);
        list.AddLast(2);

        list.Remove(2);  // Should remove the first '2'

        Assert.Equal(3, list.Count);
        Assert.Equal(1, list.Head.Data);
        Assert.Equal(2, list.Tail.Data);

        // Check the sequence is 1 -> 3 -> 2
        Assert.Equal(3, list.Head.Next.Data);
        Assert.Equal(2, list.Tail.Data);

        PrintList(list);
    }

    [Fact]
    public void Remove_Value_NotPresent_ShouldNotChangeList()
    {
        var list = new USinglyLinkedList<int>();
        list.AddLast(1);
        list.AddLast(2);

        list.Remove(99);  // No '99' in list

        Assert.Equal(2, list.Count);
        Assert.Equal(1, list.Head.Data);
        Assert.Equal(2, list.Tail.Data);

        PrintList(list);
    }
}