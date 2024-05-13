using System.Collections.Generic;
using System;

public class FirstDuplicateValue {
    //O(n) and O(n) time and space
  public int FirstDuplicateValueSolution1(int[] array) {
    HashSet<int> visitedNodes = new HashSet<int>();
    for(int i=0;i<array.Length;i++)
    {
        if(visitedNodes.Count==0||!visitedNodes.Contains(array[i]))
            visitedNodes.Add(array[i]);
        else
            return array[i];
    }
    return -1;
  }

//O(n) time and O(1) space
  public int FirstDuplicateValueSolution2(int[] array)
  {
    foreach(var value in array)
    {
        int absValue = Math.Abs(value);
        if(array[absValue-1]<0)
            return absValue;
        array[absValue=1]*=-1;
    }
    return -1;
  }
}
