using System.Linq;
public class TandemBicycleAlgo
{
  public int TandemBicycle(int[] redShirtSpeeds, int[] blueShirtSpeeds, bool fastest) {
    // Write your code here.
    var totalSpeed = 0;
    Array.Sort(redShirtSpeeds);
    Array.Sort(blueShirtSpeeds);
    if (fastest) Array.Reverse(blueShirtSpeeds);
    for (int i = 0; i < redShirtSpeeds.Length; i++)
    {
       totalSpeed += redShirtSpeeds[i] > blueShirtSpeeds[i] ? redShirtSpeeds[i] : blueShirtSpeeds[i];
    }
    return totalSpeed;
  }
}