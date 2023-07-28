public static class BranchSum
{
    public static List<int> BranchSums(BinaryTree root) 
    {
        var sums = new List<int>();
        CalculateBranchSums(root, 0, sums);
        return sums;
    }

    public static void CalculateBranchSums(BinaryTree node, int runningSum, List<int >sums)
    {
        if (node is null)  return;

        var newRunningSum = runningSum + node.value;

        if(node.left == null && node.right == null)
        {
           sums.Add(newRunningSum);
        }
        
        CalculateBranchSums(node.left, newRunningSum, sums);
        CalculateBranchSums(node.right, newRunningSum, sums);

    }
}

//                      1   0 -> running sum       Binary tree not a binary Search tree.
//                     / \       
//              1     2   3        1           
//                   / \  / \             [15, 16, 18, 10, 11]
//                  4   5 6  7
//                 / \  /
//                8   9 10        the logic is to add the running sum to all the children nodes
public class BinaryTree {
    public int value;
    public BinaryTree left;
    public BinaryTree right;

    public BinaryTree(int value) {
      this.value = value;
      this.left = null;
      this.right = null;
    }
}