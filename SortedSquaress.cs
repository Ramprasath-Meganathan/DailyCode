using System;

//Space and Time complexity - O(n) 
public class Program {
  public int[] SortedSquaredArray(int[] array) {
    int length = array.Length;
      int[] outputArray = new int[length];
      int maxValue = length -1 ;
      int minValue = 0;
      for(int j = length -1; j >= 0; j--)
      {
          if(Math.Abs(array[minValue])> Math.Abs(array[maxValue]))
          {
              outputArray[j] = array[minValue]*array[minValue];
              minValue++;
          }
          else
          {
              outputArray[j] = array[maxValue]*array[maxValue];
              maxValue--;
          }
      }
      return outputArray;
  }
}
