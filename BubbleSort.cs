using System;

public class  BubbleSortProgram {

    //O(n) O(1) - best
    // O(n2) O(1) - space
  public static int[] BubbleSort(int[] array) {
   if(array.Length ==0)
   {
       return new int[] {};
   }
    bool isSorted = false;
    int counter = 0;
    while(!isSorted)
    {
        isSorted = true;
        for(int i=0;i < array.Length-1-counter;i++)
        {
            if(array[i]>array[i+1]) 
            {
                int temp=array[i+1];
                array[i+1] = array[i];
                array[i] = temp;
                isSorted = false;
            }
        }
    counter++;
    }
    return array;
  }

}
