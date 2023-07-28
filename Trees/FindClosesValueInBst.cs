using System.Runtime.InteropServices;
using System;
public static class CloseetValueINBST{
    public static int FindClosestValueInBst(BST tree, int target) {
		// Write your code here.

        var smallestDifference = int.MaxValue;
        var closestValue = 0;
        var currentNode = tree;
        while (tree != null)
        {
            int currentDifference = Math.Abs(target - currentNode.value);

            if (currentDifference < smallestDifference)
            {
                smallestDifference = currentDifference;
                closestValue = currentNode.value;
            }

            if (target > currentNode.value)
            {
                currentNode = currentNode.right;
            }
            
            else
            {
                currentNode = currentNode.left;
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