using System;

public class SmallestDifference {
  //O(n2) time and O(1) space 
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
        }
    }
    return smallestDifferenceArray;
  }
}

// Problem statement

//   Write a function that takes in two non-empty arrays of integers, finds the
//   pair of numbers (one from each array) whose absolute difference is closest to
//   zero, and returns an array containing these two numbers, with the number from
//   the first array in the first position.

//   Note that the absolute difference of two integers is the distance between
//   them on the real number line. For example, the absolute difference of -5 and 5
//   is 10, and the absolute difference of -5 and -4 is 1.

//   You can assume that there will only be one pair of numbers with the smallest
//   difference.

// Yay, your code passed all the test cases!

// 10 / 10 test cases passed.

// Test Case 1 passed!
// Expected Output
// [28, 26]
// Your Code's Output
// [28, 26]
// View Outputs Side By Side
// Input(s)
// {
//   "arrayOne": [-1, 5, 10, 20, 28, 3],
//   "arrayTwo": [26, 134, 135, 15, 17]
// }
// Test Case 2 passed!
// Expected Output
// [20, 17]
// Your Code's Output
// [20, 17]
// View Outputs Side By Side
// Input(s)
// {
//   "arrayOne": [-1, 5, 10, 20, 3],
//   "arrayTwo": [26, 134, 135, 15, 17]
// }
// Test Case 3 passed!
// Expected Output
// [25, 1005]
// Your Code's Output
// [25, 1005]
// View Outputs Side By Side
// Input(s)
// {
//   "arrayOne": [10, 0, 20, 25],
//   "arrayTwo": [1005, 1006, 1014, 1032, 1031]
// }
// Test Case 4 passed!
// Expected Output
// [25, 1005]
// Your Code's Output
// [25, 1005]
// View Outputs Side By Side
// Input(s)
// {
//   "arrayOne": [10, 0, 20, 25, 2200],
//   "arrayTwo": [1005, 1006, 1014, 1032, 1031]
// }
// Test Case 5 passed!
// Expected Output
// [2000, 1032]
// Your Code's Output
// [2000, 1032]
// View Outputs Side By Side
// Input(s)
// {
//   "arrayOne": [10, 0, 20, 25, 2000],
//   "arrayTwo": [1005, 1006, 1014, 1032, 1031]
// }
// Test Case 6 passed!
// Expected Output
// [954, 954]
// Your Code's Output
// [954, 954]
// View Outputs Side By Side
// Input(s)
// {
//   "arrayOne": [240, 124, 86, 111, 2, 84, 954, 27, 89],
//   "arrayTwo": [1, 3, 954, 19, 8]
// }
// Test Case 7 passed!
// Expected Output
// [20, 21]
// Your Code's Output
// [20, 21]
// View Outputs Side By Side
// Input(s)
// {
//   "arrayOne": [0, 20],
//   "arrayTwo": [21, -2]
// }
// Test Case 8 passed!
// Expected Output
// [1000, 1014]
// Your Code's Output
// [1000, 1014]
// View Outputs Side By Side
// Input(s)
// {
//   "arrayOne": [10, 1000],
//   "arrayTwo": [-1441, -124, -25, 1014, 1500, 660, 410, 245, 530]
// }
// Test Case 9 passed!
// Expected Output
// [-123, -124]
// Your Code's Output
// [-123, -124]
// View Outputs Side By Side
// Input(s)
// {
//   "arrayOne": [10, 1000, 9124, 2142, 59, 24, 596, 591, 124, -123],
//   "arrayTwo": [-1441, -124, -25, 1014, 1500, 660, 410, 245, 530]
// }
// Test Case 10 passed!
// Expected Output
// [530, 530]
// Your Code's Output
// [530, 530]
// View Outputs Side By Side
// Input(s)
// {
//   "arrayOne": [10, 1000, 9124, 2142, 59, 24, 596, 591, 124, -123, 530],
//   "arrayTwo": [-1441, -124, -25, 1014, 1500, 660, 410, 245, 530]
// }