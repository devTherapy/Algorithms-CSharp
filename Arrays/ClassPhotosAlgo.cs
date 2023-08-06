public class ClassPhotosAlgo
{
     public bool ClassPhotos(List<int> redShirtHeights, List<int> blueShirtHeights) {
    // Write your code here.
    redShirtHeights.Sort();
    blueShirtHeights.Sort();
    var redIsBackRow = redShirtHeights[^1] > blueShirtHeights[^1];
    for (int i = 0; i < redShirtHeights.Count; i++)
    {
        if (redIsBackRow && redShirtHeights[i] <= blueShirtHeights[i]) return false;  
        else if (blueShirtHeights[i] <= redShirtHeights[i]) return false;

    }
    return true;
  }
}