


// Create the input tree: [1,null,2,null,3,null,4,null,null]
using solution;

TreeNode root = new(1)
{
  right = new TreeNode(2)
};
root.right.right = new TreeNode(3)
{
  right = new TreeNode(4)
};

// Call the BalanceBST function
Solution solution = new();
TreeNode balancedRoot = solution.BalanceBST(root);

// Print the balanced tree in-order
PrintInOrderTraversal(balancedRoot);

void PrintInOrderTraversal(TreeNode node)
{
  if (node == null)
  {
    return;
  }

  PrintInOrderTraversal(node.left);
  Console.Write(node.val + " ");
  PrintInOrderTraversal(node.right);
}
