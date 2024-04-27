using System;

public class FindThreeLargestNumbers {
    //O(n) time and O(1) space
  public static int[] FindThreeLargestNumbersPgm(int[] array) {
    int[] largestArray = {Int32.MinValue,Int32.MinValue, Int32.MinValue};
    foreach(int val in array)
    {
        updateLargestValue(largestArray,val);
    }
      return largestArray;
}

    public static void updateLargestValue(int[] largestArray, int val)
    {
        if(val>largestArray[2])
            ShiftAndUpdate(largestArray, val, 2);
        else if (val> largestArray[1])
            ShiftAndUpdate(largestArray, val, 1);
        else if (val> largestArray[0])
            ShiftAndUpdate(largestArray, val, 0);
    }

    public static void ShiftAndUpdate(int[] array, int val, int idx)
    {
        for(int i=0;i<=idx;i++)
        {
            if(i==idx)
                array[i] = val;
            else
                array[i] = array[i+1];
        }
    }
}

// Problem statement
//   Write a function that takes in an array of at least three integers and,
//   without sorting the input array, returns a sorted array of the three largest
//   integers in the input array.

//   The function should return duplicate integers if necessary; for example, it
//   should return [10, 10, 12]  for an input array of [10, 5, 9, 10, 12].

// Test casesYay, your code passed all the test cases!

// 8 / 8 test cases passed.

// Test Case 1 passed!
// Expected Output
// [18, 141, 541]
// Your Code's Output
// [18, 141, 541]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7]
// }
// Test Case 2 passed!
// Expected Output
// [7, 8, 55]
// Your Code's Output
// [7, 8, 55]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [55, 7, 8]
// }
// Test Case 3 passed!
// Expected Output
// [11, 43, 55]
// Your Code's Output
// [11, 43, 55]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [55, 43, 11, 3, -3, 10]
// }
// Test Case 4 passed!
// Expected Output
// [11, 43, 55]
// Your Code's Output
// [11, 43, 55]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [7, 8, 3, 11, 43, 55]
// }
// Test Case 5 passed!
// Expected Output
// [11, 43, 55]
// Your Code's Output
// [11, 43, 55]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [55, 7, 8, 3, 43, 11]
// }
// Test Case 6 passed!
// Expected Output
// [7, 7, 7]
// Your Code's Output
// [7, 7, 7]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7]
// }
// Test Case 7 passed!
// Expected Output
// [7, 7, 8]
// Your Code's Output
// [7, 7, 8]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [7, 7, 7, 7, 7, 7, 8, 7, 7, 7, 7]
// }
// Test Case 8 passed!
// Expected Output
// [-2, -1, 7]
// Your Code's Output
// [-2, -1, 7]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [-1, -2, -3, -7, -17, -27, -18, -541, -8, -7, 7]
// }