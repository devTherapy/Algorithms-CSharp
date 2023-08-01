public static class NodeDepth
{

     public static int NodeDepths(BinaryTree root) 
     {
        var sumOfNodeDepths = 0;
        var currentNodeDepth = 0;
         SumNodeDepths(root, currentNodeDepth, ref sumOfNodeDepths);
        // Write your code here.
         return sumOfNodeDepths;
     }

    private static void SumNodeDepths(BinaryTree node, int currentNodeDepth, ref int sumOfNodeDepths)
    {
        if(node == null) return;
        sumOfNodeDepths += currentNodeDepth;
        SumNodeDepths(node.left, currentNodeDepth + 1, ref sumOfNodeDepths);
        SumNodeDepths(node.right, currentNodeDepth + 1, ref sumOfNodeDepths);

    }
}