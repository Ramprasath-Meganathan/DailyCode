using System;

public class SelectionSortProgram {
  public static int[] SelectionSort(int[] array) {
    if(array.Length==0)
        return new int[] {};
    int minElementIndex = 0;
    int counter = 0;
    while(counter<array.Length)
    {
    minElementIndex = counter;
    for(int i=counter+1;i<array.Length;i++)
    {
        if(array[i]<array[minElementIndex])
               minElementIndex = i;
    }
     if(minElementIndex!=counter)
         Swap(counter,minElementIndex,array);
     counter++;
    }
    return array;
  }
 public static void Swap(int counter, int minElementIndex, int[] array)
 {
     int temp = array[counter];
     array[counter] = array[minElementIndex];
     array[minElementIndex] = temp;
 }
}
