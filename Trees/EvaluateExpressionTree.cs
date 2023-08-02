public class EvaluateExpressionTreeAlgo{

 public int EvaluateExpressionTree(BinaryTree tree) {
// Write your code here.

//                     -1               
//                     / \       
//                   -2   -3                   
//                   / \  / \             
//                 -4   2 8  3
//                 / \  
//                2   3      

    if (tree.value > 0) return tree.value;

    var leftValue = EvaluateExpressionTree(tree.left);
    var rightValue = EvaluateExpressionTree(tree.right);

    switch (tree.value)
    {
        case -1:
        return leftValue + rightValue;
        case -2:
        return leftValue - rightValue;
        case -3:
        return (int) leftValue / rightValue;       
        default:
        return leftValue * rightValue;
    }
  }
}