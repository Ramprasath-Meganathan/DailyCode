using System;

public class InsertionSortPgm {
  public static int[] InsertionSort(int[] array) {
    if(array.Length==0)
        return new int[] {};
    int counter=1;
    // O(n) - time and O(1) space
    while(counter<array.Length)
    {
    for(int i=0;i<counter;i++)
    {
        if(array[i]>array[counter])
        {
            int temp = array[i];
            array[i] = array[counter];
            array[counter] = temp;
        }
    }
      counter++;
    }
    return array;
  }
}
