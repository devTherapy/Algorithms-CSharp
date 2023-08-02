public static class NodeDepth
{

    //recursion solution
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

    //Iterative approach
    public static int NodeDepths_Iterative(BinaryTree root) 
    {
        var sumOfNodeDepths = 0;
        var stack =  new Stack<(BinaryTree node, int nodeDepth)>();
        stack.Push((root, 0));
        while (stack.Count > 0)
        {
            var (node, nodeDepth) = stack.Pop();
            sumOfNodeDepths += nodeDepth;
            if(node.left is not null) stack.Push((node.left, nodeDepth + 1));
            if(node.right is not null) stack.Push((node.right, nodeDepth + 1));
        }
        return sumOfNodeDepths;
    }


}