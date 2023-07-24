using System;
public static class CloseetValueINBST{
    public static int FindClosestValueInBst(BST tree, int target) {
		// Write your code here.

        var closestValue = tree.value;

        while (tree != null)
        {
            int currentDifference = Math.Abs(target - tree.value);

            if (Math.Abs(closestValue - target)  > Math.Abs(tree.value - target))
            {
                closestValue = tree.value;
            }

            if (target == tree.value)
            {
                return closestValue;
            }

            else if (target > tree.value)
            {
                tree = tree.right;
            }

            else
            {
                tree = tree.left;
            }
        }
		return closestValue;
	}


   
}

 public class BST {
		public int value;
		public BST left;
		public BST right;

		public BST(int value) {
			this.value = value;
		}
	}