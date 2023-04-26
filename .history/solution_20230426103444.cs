namespace solution
{


  public class TreeNode
  {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
      this.val = val;
      this.left = left;
      this.right = right;
    }
  }

  public class Solution
  {
    public TreeNode BalanceBST(TreeNode root)
    {
      List<TreeNode> nodes = new List<TreeNode>();
      InOrderTraversal(root, nodes);
      return BuildBalancedBST(nodes, 0, nodes.Count - 1);
    }

    private void InOrderTraversal(TreeNode node, List<TreeNode> nodes)
    {
      if (node == null) return;
      InOrderTraversal(node.left, nodes);
      nodes.Add(node);
      InOrderTraversal(node.right, nodes);
    }

    private TreeNode BuildBalancedBST(List<TreeNode> nodes, int start, int end)
    {
      if (start > end) return null;

      int mid = start + (end - start) / 2;
      TreeNode newNode = new TreeNode(nodes[mid].val);
      newNode.left = BuildBalancedBST(nodes, start, mid - 1);
      newNode.right = BuildBalancedBST(nodes, mid + 1, end);

      return newNode;
    }
  }
}
