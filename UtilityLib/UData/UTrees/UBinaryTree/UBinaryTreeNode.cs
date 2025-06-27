using System.Diagnostics.CodeAnalysis;

namespace UtilityLib.UData.UTrees;

public partial class UBinaryTreeNode<T>
{
    [NotNull]
    public T Value { get; set; }
    public int NodeDepth { get; set; }
    public UBinaryTree<T> Root { get; set; }
    public UBinaryTreeNode<T>? Parent { get; set; } = null;
    public UBinaryTreeNode<T>? Left { get; set; } = null;
    public UBinaryTreeNode<T>? Right { get; set; } = null;

    public UBinaryTreeNode(T value)
    {
        Value = value;
    }

    public UBinaryTreeNode(UBinaryTreeNode<T> _ParentNode, T value)
    {
        Value = value;
        Parent = _ParentNode;
        Root = _ParentNode.Root;
        NodeDepth = _ParentNode.NodeDepth + 1;
        Root.Height = NodeDepth;
    }

    public void SetNode(T value, TreeOrientation TreeOrientation)
    {
        if (TreeOrientation == TreeOrientation.left)
            Left = new UBinaryTreeNode<T>(this, value);
        else if (TreeOrientation == TreeOrientation.right)
            Right = new UBinaryTreeNode<T>(this, value);
        else { throw new ArgumentException($"BinaryTree does not support orientation: {TreeOrientation.ToString()}"); }
    }

    public void RemoveNode(TreeOrientation TreeOrientation)
    {
        if (TreeOrientation == TreeOrientation.left)
            Left = null;
        else if (TreeOrientation == TreeOrientation.right)
            Right = null;
        else { throw new ArgumentException($"BinaryTree does not support orientation: {TreeOrientation.ToString()}"); }
    }
}
