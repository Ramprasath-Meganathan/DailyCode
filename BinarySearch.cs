using System;

public class BinarySearchClass {
// O(logn) time and O(1) space
  public static int BinarySearch(int[] array, int target) {
    int first =0;
    int last = array.Length-1;
    int mid=0;
    while(first<=last)
    {
    mid = Math.Abs(first + last)/2;
    if(target<array[mid])
        last = mid-1;
    else if(target> array[mid])
        first = mid+1;
    else
        return mid;
    }
    return -1;
  }
}
