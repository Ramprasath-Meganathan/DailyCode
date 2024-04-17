using System.Collections.Generic;
using System.Linq;

public class ClassPhotos {
    //time O(nlogn) and space O(1)
  public bool ClassPhotosMethod(
    List<int> redShirtHeights, List<int> blueShirtHeights
  ) {
    redShirtHeights.Sort();
    blueShirtHeights.Sort();
    int loopVar = blueShirtHeights.Count;
    bool guidelinePassed = true;
    bool isRedShirtTall = redShirtHeights.Max()>blueShirtHeights.Max();
    for(int i=loopVar-1;i>=0;i--)
    {
        if(isRedShirtTall)
              guidelinePassed = CheckGuidelines(redShirtHeights[i],blueShirtHeights[i]);
        else
             guidelinePassed = CheckGuidelines(blueShirtHeights[i],redShirtHeights[i]);
      if(!guidelinePassed)
           break;
  }
    return guidelinePassed;
  }
  public static bool CheckGuidelines(int taller, int shorter)
  {
      return taller>shorter;
  }
}
