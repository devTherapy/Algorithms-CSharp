// See https://aka.ms/new-console-template for more information
//var inputArray = new int[]{-10, -5, 0, 5, 10};
//var ans = SortedSquare.SortedSquaredArray(inputArray);

var array = new List<int>{5, 1, 22, 25, 6, -1, 8, 10};
var sequence = new List<int>{22, 25, 6};
// [2, [7, 6, [5]]]
var objects = new List<object>{2, new List<object>{7, 6, new List<object>{5}}};

ProductSumAlgo.ProductSum(objects);
//System.Console.WriteLine(ans);