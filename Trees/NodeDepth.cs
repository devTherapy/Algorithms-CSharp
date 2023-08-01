public static class NodeDepth
{

     public static int NodeDepths(BinaryTree root) 
     {
        var sumOfNodeDepths = 0;
        var currentDepth = 0;
         SumNodeDepths(root, currentDepth, ref sumOfNodeDepths);
        // Write your code here.
         return sumOfNodeDepths;
     }

    private static void SumNodeDepths(BinaryTree node, int currentDepth, ref int sumOfNodeDepths)
    {
        if(node == null) return;
        sumOfNodeDepths = currentDepth + 1;
        SumNodeDepths(node.left, currentDepth + 1, ref sumOfNodeDepths);
        SumNodeDepths(node.right, currentDepth + 1, ref sumOfNodeDepths);

    }
}