public class NonConstructibleChange {
    //O(nlogn) time and O(1) space
public int NonConstructibleChangePgm(int[] coins) {
 Array.Sort(coins);
int currentCreatedChange = 0;
foreach(var coin in coins)
{
    if(coin>currentCreatedChange+1)
    {
        return currentCreatedChange+1;
    }
    currentCreatedChange+=coin;
}
return currentCreatedChange+1;
}
}

// Problem statement

//   Given an array of positive integers representing the values of coins in your
//   possession, write a function that returns the minimum amount of change (the
//   minimum sum of money) that you cannot  create. The given coins can have
//   any positive integer value and aren't necessarily unique (i.e., you can have
//   multiple coins of the same value).

//   For example, if you're given coins = [1, 2, 5] , the minimum
//   amount of change that you can't create is  4. , . If you're given no
//   coins, the minimum amount of change that you can't create is 1

//   Test cases
//   Custom Output

// Raw Output

// Submit Code
// Yay, your code passed all the test cases!

// 13 / 13 test cases passed.

// Test Case 1 passed!
// Expected Output
// 20
// Your Code's Output
// 20
// View Outputs Side By Side
// Input(s)
// {
//   "coins": [5, 7, 1, 1, 2, 3, 22]
// }
// Test Case 2 passed!
// Expected Output
// 6
// Your Code's Output
// 6
// View Outputs Side By Side
// Input(s)
// {
//   "coins": [1, 1, 1, 1, 1]
// }
// Test Case 3 passed!
// Expected Output
// 55
// Your Code's Output
// 55
// View Outputs Side By Side
// Input(s)
// {
//   "coins": [1, 5, 1, 1, 1, 10, 15, 20, 100]
// }
// Test Case 4 passed!
// Expected Output
// 3
// Your Code's Output
// 3
// View Outputs Side By Side
// Input(s)
// {
//   "coins": [6, 4, 5, 1, 1, 8, 9]
// }
// Test Case 5 passed!
// Expected Output
// 1
// Your Code's Output
// 1
// View Outputs Side By Side
// Input(s)
// {
//   "coins": []
// }
// Test Case 6 passed!
// Expected Output
// 1
// Your Code's Output
// 1
// View Outputs Side By Side
// Input(s)
// {
//   "coins": [87]
// }
// Test Case 7 passed!
// Expected Output
// 32
// Your Code's Output
// 32
// View Outputs Side By Side
// Input(s)
// {
//   "coins": [5, 6, 1, 1, 2, 3, 4, 9]
// }
// Test Case 8 passed!
// Expected Output
// 19
// Your Code's Output
// 19
// View Outputs Side By Side
// Input(s)
// {
//   "coins": [5, 6, 1, 1, 2, 3, 43]
// }
// Test Case 9 passed!
// Expected Output
// 3
// Your Code's Output
// 3
// View Outputs Side By Side
// Input(s)
// {
//   "coins": [1, 1]
// }
// Test Case 10 passed!
// Expected Output
// 1
// Your Code's Output
// 1
// View Outputs Side By Side
// Input(s)
// {
//   "coins": [2]
// }
// Test Case 11 passed!
// Expected Output
// 2
// Your Code's Output
// 2
// View Outputs Side By Side
// Input(s)
// {
//   "coins": [1]
// }
// Test Case 12 passed!
// Expected Output
// 87
// Your Code's Output
// 87
// View Outputs Side By Side
// Input(s)
// {
//   "coins": [109, 2000, 8765, 19, 18, 17, 16, 8, 1, 1, 2, 4]
// }
// Test Case 13 passed!
// Expected Output
// 29
// Your Code's Output
// 29
// View Outputs Side By Side
// Input(s)
// {
//   "coins": [1, 2, 3, 4, 5, 6, 7]
// }
