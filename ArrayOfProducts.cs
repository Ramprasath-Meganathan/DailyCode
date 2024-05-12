using System;

public class ArrayOfProducts {
    //O(n2) and O(n) space
  public int[] ArrayOfProductsSolution1(int[] array) {
    int pointer=0;
    int[] productArray = new int[array.Length];
    while(pointer<array.Length)
    {
    int product=Int32.MinValue;
    for(int i=0;i<array.Length;i++)
    {
        if(pointer==i)
            continue;
        if(product==Int32.MinValue)
            product=array[i];
        else
            product*=array[i];  
    }
    productArray[pointer]=product;
    pointer++;
    }
    return productArray;
  }

//O(n) tiem and O(n) space
   public int[] ArrayOfProductsSolution2(int[] array) {
    int[] products = new int[array.Length];

    int leftRunningProduct =1;
    for(int i=0;i<array.Length;i++)
    {
        products[i] = leftRunningProduct;
        leftRunningProduct*=array[i];
    }
    int rightRunningProduct=1;
    for(int i=array.Length-1;i>=0;i--)
    {
        products[i]*=rightRunningProduct;
        rightRunningProduct*=array[i];
    }
    return products;
  }
}

//Problem statement

//   Write a function that takes in a non-empty array of integers and returns an
//   array of the same length, where each element in the output array is equal to
//   the product of every other number in the input array. 
//   In other words, the value at output[i]  is equal to the product of
//   every number in the input array other than input[i]. Note that you're expected to solve this problem without using division.

// Test cases
//   Yay, your code passed all the test cases!

// 11 / 11 test cases passed.

// Test Case 1 passed!
// Expected Output
// [8, 40, 10, 20]
// Your Code's Output
// [8, 40, 10, 20]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [5, 1, 4, 2]
// }
// Test Case 2 passed!
// Expected Output
// [384, 48, 64, 192, 96]
// Your Code's Output
// [384, 48, 64, 192, 96]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 8, 6, 2, 4]
// }
// Test Case 3 passed!
// Expected Output
// [672, -1680, 840, -240, 560]
// Your Code's Output
// [672, -1680, 840, -240, 560]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [-5, 2, -4, 14, -6]
// }
// Test Case 4 passed!
// Expected Output
// [1620, 4860, 7290, 14580, 1620, 2916, 4860, 7290]
// Your Code's Output
// [1620, 4860, 7290, 14580, 1620, 2916, 4860, 7290]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [9, 3, 2, 1, 9, 5, 3, 2]
// }
// Test Case 5 passed!
// Expected Output
// [4, 4]
// Your Code's Output
// [4, 4]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [4, 4]
// }
// Test Case 6 passed!
// Expected Output
// [0, 0, 0, 0]
// Your Code's Output
// [0, 0, 0, 0]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [0, 0, 0, 0]
// }
// Test Case 7 passed!
// Expected Output
// [1, 1, 1, 1]
// Your Code's Output
// [1, 1, 1, 1]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [1, 1, 1, 1]
// }
// Test Case 8 passed!
// Expected Output
// [1, 1, 1]
// Your Code's Output
// [1, 1, 1]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [-1, -1, -1]
// }
// Test Case 9 passed!
// Expected Output
// [-1, -1, -1, -1]
// Your Code's Output
// [-1, -1, -1, -1]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [-1, -1, -1, -1]
// }
// Test Case 10 passed!
// Expected Output
// [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
// Your Code's Output
// [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [0, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
// }
// Test Case 11 passed!
// Expected Output
// [362880, 0, 0, 0, 0, 0, 0, 0, 0, 0]
// Your Code's Output
// [362880, 0, 0, 0, 0, 0, 0, 0, 0, 0]
// View Outputs Side By Side
// Input(s)
// {
//   "array": [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
// }