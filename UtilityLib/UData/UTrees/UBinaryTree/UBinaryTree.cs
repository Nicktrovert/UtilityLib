namespace UtilityLib.UData.UTrees;

public partial class UBinaryTree<T>
{
    public UBinaryTreeNode<T> BaseNode { get; set; }
    public int Height { get; set; } = 0;

    public UBinaryTree(T Value)
    {
        BaseNode = new UBinaryTreeNode<T>(Value);
        BaseNode.Root = this;
        BaseNode.NodeDepth = 0;
    }

    public void SetNode(UBinaryTreeNode<T> node, T value, TreeOrientation TreeOrientation) => node.SetNode(value, TreeOrientation);
    public void RemoveNode(UBinaryTreeNode<T> node, TreeOrientation TreeOrientation) => node.RemoveNode(TreeOrientation);

    public bool DoesNodeExist(UBinaryTreeNode<T>? node, T key)
    {
        if (node == null)
            return false;

        if (node.Value.Equals(key))
            return true;

        // then recur on left subtree /
        bool res1 = DoesNodeExist(node.Left, key);

        // node found, no need to look further
        if (res1) return true;

        // node is not found in left, 
        // so recur on right subtree
        bool res2 = DoesNodeExist(node.Right, key);

        return res2;
    }

    public UBinaryTreeNode<T>? FindNodeByValue(UBinaryTreeNode<T>? node, T value)
    {
        if (node == null || node.Value.Equals(value))
            return node;

        // then recur on left subtree
        UBinaryTreeNode<T>? res1 = FindNodeByValue(node.Left, value);

        // node found, no need to look further
        if (res1 != null) return res1;

        // node is not found in left, 
        // so recur on right subtree 
        UBinaryTreeNode<T>? res2 = FindNodeByValue(node.Right, value);

        return res2;
    }

    private int GetSizeRecursor(UBinaryTreeNode<T>? node)
    {
        if (node == null)
            return 0;

        // then recur on left subtree
        int res1 = GetSizeRecursor(node.Left);
 
        // then recur on right subtree
        int res2 = GetSizeRecursor(node.Right);

        return 1 + res1 + res2;
    }

    public int GetSize() => GetSizeRecursor(this.BaseNode);
}