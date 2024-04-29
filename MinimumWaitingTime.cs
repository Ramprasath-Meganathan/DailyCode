using System.Linq;
using System;

public class MinimumWaitingTime {
//O(n2) O(n) space
  public int MinimumWaitingTimeMethod(int[] queries) {
    Array.Sort(queries);
    int length = queries.Length;
    int[] individualWaitTime = new int[length];
    if(length==1)
        return 0;
    individualWaitTime[0] = 0;
    for(int i=1;i<length;i++)
        individualWaitTime[i]= individualWaitTime[i-1]+queries[i-1];
    return individualWaitTime.Sum();
  }
}

// Problem statement
//   You're given a non-empty array of positive integers representing the amounts
//   of time that specific queries take to execute. Only one query can be executed
//   at a time, but the queries can be executed in any order.

//   A query's waiting time  is defined as the amount of time that it must
//   wait before its execution starts. In other words, if a query is executed
//   second, then its waiting time is the duration of the first query; if a query
//   is executed third, then its waiting time is the sum of the durations of the
//   first two queries.

//   Write a function that returns the minimum amount of total waiting time for all
//   of the queries. For example, if you're given the queries of durations
//  [1, 4, 5] , then the total waiting time if the queries were
//   executed in the order of [5, 1, 4]  would be (0) + (5) + (5 + 1) = 11 . The first query of duration
//    would be executed immediately, so its waiting time would be 0 , the second query of duration 1
//    would have to wait 5  seconds (the duration of the first query) to be executed, and
//   the last query would have to wait the duration of the first two queries before
//   being executed.

//   Test cases

//   15 / 15 test cases passed.

// Test Case 1 passed!
// Expected Output
// 17
// Your Code's Output
// 17
// View Outputs Side By Side
// Input(s)
// {
//   "queries": [3, 2, 1, 2, 6]
// }
// Test Case 2 passed!
// Expected Output
// 6
// Your Code's Output
// 6
// View Outputs Side By Side
// Input(s)
// {
//   "queries": [2, 1, 1, 1]
// }
// Test Case 3 passed!
// Expected Output
// 23
// Your Code's Output
// 23
// View Outputs Side By Side
// Input(s)
// {
//   "queries": [1, 2, 4, 5, 2, 1]
// }
// Test Case 4 passed!
// Expected Output
// 32
// Your Code's Output
// 32
// View Outputs Side By Side
// Input(s)
// {
//   "queries": [25, 30, 2, 1]
// }
// Test Case 5 passed!
// Expected Output
// 10
// Your Code's Output
// 10
// View Outputs Side By Side
// Input(s)
// {
//   "queries": [1, 1, 1, 1, 1]
// }
// Test Case 6 passed!
// Expected Output
// 19
// Your Code's Output
// 19
// View Outputs Side By Side
// Input(s)
// {
//   "queries": [7, 9, 2, 3]
// }
// Test Case 7 passed!
// Expected Output
// 45
// Your Code's Output
// 45
// View Outputs Side By Side
// Input(s)
// {
//   "queries": [4, 3, 1, 1, 3, 2, 1, 8]
// }
// Test Case 8 passed!
// Expected Output
// 0
// Your Code's Output
// 0
// View Outputs Side By Side
// Input(s)
// {
//   "queries": [2]
// }
// Test Case 9 passed!
// Expected Output
// 0
// Your Code's Output
// 0
// View Outputs Side By Side
// Input(s)
// {
//   "queries": [7]
// }
// Test Case 10 passed!
// Expected Output
// 8
// Your Code's Output
// 8
// View Outputs Side By Side
// Input(s)
// {
//   "queries": [8, 9]
// }
// Test Case 11 passed!
// Expected Output
// 1
// Your Code's Output
// 1
// View Outputs Side By Side
// Input(s)
// {
//   "queries": [1, 9]
// }
// Test Case 12 passed!
// Expected Output
// 20
// Your Code's Output
// 20
// View Outputs Side By Side
// Input(s)
// {
//   "queries": [5, 4, 3, 2, 1]
// }
// Test Case 13 passed!
// Expected Output
// 20
// Your Code's Output
// 20
// View Outputs Side By Side
// Input(s)
// {
//   "queries": [1, 2, 3, 4, 5]
// }
// Test Case 14 passed!
// Expected Output
// 81
// Your Code's Output
// 81
// View Outputs Side By Side
// Input(s)
// {
//   "queries": [1, 1, 1, 4, 5, 6, 8, 1, 1, 2, 1]
// }
// Test Case 15 passed!
// Expected Output
// 10
// Your Code's Output
// 10
// View Outputs Side By Side
// Input(s)
// {
//   "queries": [17, 4, 3]
// }