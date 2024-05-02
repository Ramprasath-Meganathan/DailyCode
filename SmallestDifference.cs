using System;

public class SmallestDifference {
  public static int[] SmallestDifferenceMethod(int[] arrayOne, int[] arrayTwo) {
    Array.Sort(arrayOne);
    Array.Sort(arrayTwo);
    int smallestDifference = 0;
    int[] smallestDifferenceArray = new int[2];
    for(int i=0;i<arrayOne.Length;i++)
    {
        for(int j=0;j<arrayTwo.Length;j++)
        {
            int currentDifference = Math.Abs(arrayOne[i])-Math.Abs(arrayTwo[j]);
            if((i==0&&j==0)||Math.Abs(currentDifference)<smallestDifference)
            {
                smallestDifference = currentDifference;
                smallestDifferenceArray[0]= arrayOne[i];
                smallestDifferenceArray[1]= arrayTwo[j];
            }
            else
                break;
        }
    }
    return smallestDifferenceArray;
  }
}
