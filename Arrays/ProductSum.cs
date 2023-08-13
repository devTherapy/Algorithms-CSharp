public class ProductSumAlgo{

    public static int ProductSum(List<object> array) {
    // Write your code here
    return ProductSum(array,1);
  }

    public static int ProductSum(IList<object> array, int depth){
        var sum = 0;
        foreach (var item in array)
        {
            sum += item is IList<object> ? ProductSum(item as IList<object>, depth + 1) : 
            (int)item;
        }
        return sum * depth;
    }
}