using System;

//O(nlogn) time and O(1) space
public class TandemBicycle {
  public int TandemBicycleMethod(
    int[] redShirtSpeeds, int[] blueShirtSpeeds, bool fastest
  ) {
    Array.Sort(redShirtSpeeds);
    if(fastest)
        Array.Reverse(redShirtSpeeds);
    Array.Sort(blueShirtSpeeds);
    int size = blueShirtSpeeds.Length;
    int sum = 0;
    for(int i=0;i<size;i++)
        sum += redShirtSpeeds[i]>blueShirtSpeeds[i] ? redShirtSpeeds[i]: blueShirtSpeeds[i];
    return sum;
  }
}

//Problem statement
//   A tandem bicycle is a bicycle that's operated by two people: person A and
//   person B. Both people pedal the bicycle, but the person that pedals faster
//   dictates the speed of the bicycle. So if person A pedals at a speed of 5
//   , and person B pedals at a speed of 4 , the tandem
//   bicycle moves at a speed of 5  (i.e.,
// tandemSpeed = max(speedA, speedB)

//   You're given two lists of positive integers: one that contains the speeds of
//   riders wearing red shirts and one that contains the speeds of riders wearing
//   blue shirts. Each rider is represented by a single positive integer, which is
//   the speed that they pedal a tandem bicycle at. Both lists have the same
//   length, meaning that there are as many red-shirt riders as there are
//   blue-shirt riders. Your goal is to pair every rider wearing a red shirt with a
//   rider wearing a blue shirt to operate a tandem bicycle.


//   Write a function that returns the maximum possible total speed or the minimum
//   possible total speed of all of the tandem bicycles being ridden based on an
//   input parameter, fastest . If fastest = true , your
//   function should return the maximum possible total speed; otherwise it should
//   return the minimum total speed.

//   "Total speed" is defined as the sum of the speeds of all the tandem bicycles
//   being ridden. For example, if there are 4 riders (2 red-shirt riders and 2
//   blue-shirt riders) who have speeds of 
//   1, 3, 4, 5 , and if they're
//   paired on tandem bicycles as follows: [1, 4], [5, 3] , then the
//   total speed of these tandem bicycles is 4 + 5 = 9


// Test cases
// Test Case 1 passed!
// Expected Output
// 32
// Your Code's Output
// 32
// View Outputs Side By Side
// Input(s)
// {
//   "blueShirtSpeeds": [3, 6, 7, 2, 1],
//   "fastest": true,
//   "redShirtSpeeds": [5, 5, 3, 9, 2]
// }
// Test Case 2 passed!
// Expected Output
// 25
// Your Code's Output
// 25
// View Outputs Side By Side
// Input(s)
// {
//   "blueShirtSpeeds": [3, 6, 7, 2, 1],
//   "fastest": false,
//   "redShirtSpeeds": [5, 5, 3, 9, 2]
// }
// Test Case 3 passed!
// Expected Output
// 30
// Your Code's Output
// 30
// View Outputs Side By Side
// Input(s)
// {
//   "blueShirtSpeeds": [3, 3, 4, 6, 1, 2],
//   "fastest": false,
//   "redShirtSpeeds": [1, 2, 1, 9, 12, 3]
// }
// Test Case 4 passed!
// Expected Output
// 37
// Your Code's Output
// 37
// View Outputs Side By Side
// Input(s)
// {
//   "blueShirtSpeeds": [3, 3, 4, 6, 1, 2],
//   "fastest": true,
//   "redShirtSpeeds": [1, 2, 1, 9, 12, 3]
// }
// Test Case 5 passed!
// Expected Output
// 816
// Your Code's Output
// 816
// View Outputs Side By Side
// Input(s)
// {
//   "blueShirtSpeeds": [3, 3, 4, 6, 1, 2, 5, 6, 34, 256, 123, 32],
//   "fastest": true,
//   "redShirtSpeeds": [1, 2, 1, 9, 12, 3, 1, 54, 21, 231, 32, 1]
// }
// Test Case 6 passed!
// Expected Output
// 484
// Your Code's Output
// 484
// View Outputs Side By Side
// Input(s)
// {
//   "blueShirtSpeeds": [3, 3, 4, 6, 1, 2, 5, 6, 34, 256, 123, 32],
//   "fastest": false,
//   "redShirtSpeeds": [1, 2, 1, 9, 12, 3, 1, 54, 21, 231, 32, 1]
// }
// Test Case 7 passed!
// Expected Output
// 5
// Your Code's Output
// 5
// View Outputs Side By Side
// Input(s)
// {
//   "blueShirtSpeeds": [5],
//   "fastest": true,
//   "redShirtSpeeds": [1]
// }
// Test Case 8 passed!
// Expected Output
// 5
// Your Code's Output
// 5
// View Outputs Side By Side
// Input(s)
// {
//   "blueShirtSpeeds": [5],
//   "fastest": false,
//   "redShirtSpeeds": [1]
// }
// Test Case 9 passed!
// Expected Output
// 4
// Your Code's Output
// 4
// View Outputs Side By Side
// Input(s)
// {
//   "blueShirtSpeeds": [1, 1, 1, 1],
//   "fastest": true,
//   "redShirtSpeeds": [1, 1, 1, 1]
// }
// Test Case 10 passed!
// Expected Output
// 4
// Your Code's Output
// 4
// View Outputs Side By Side
// Input(s)
// {
//   "blueShirtSpeeds": [1, 1, 1, 1],
//   "fastest": false,
//   "redShirtSpeeds": [1, 1, 1, 1]
// }
// Test Case 11 passed!
// Expected Output
// 48
// Your Code's Output
// 48
// View Outputs Side By Side
// Input(s)
// {
//   "blueShirtSpeeds": [1, 1, 1, 1, 3, 3, 3, 3, 5, 7],
//   "fastest": true,
//   "redShirtSpeeds": [1, 1, 1, 1, 2, 2, 2, 2, 9, 11]
// }
// Test Case 12 passed!
// Expected Output
// 36
// Your Code's Output
// 36
// View Outputs Side By Side
// Input(s)
// {
//   "blueShirtSpeeds": [1, 1, 1, 1, 3, 3, 3, 3, 5, 7],
//   "fastest": false,
//   "redShirtSpeeds": [1, 1, 1, 1, 2, 2, 2, 2, 9, 11]
// }
// Test Case 13 passed!
// Expected Output
// 49
// Your Code's Output
// 49
// View Outputs Side By Side
// Input(s)
// {
//   "blueShirtSpeeds": [3, 4, 4, 1, 1, 8, 9],
//   "fastest": true,
//   "redShirtSpeeds": [9, 8, 2, 2, 3, 5, 6]
// }
// Test Case 14 passed!
// Expected Output
// 35
// Your Code's Output
// 35
// View Outputs Side By Side
// Input(s)
// {
//   "blueShirtSpeeds": [3, 4, 4, 1, 1, 8, 9],
//   "fastest": false,
//   "redShirtSpeeds": [9, 8, 2, 2, 3, 5, 6]
// }
// Test Case 15 passed!
// Expected Output
// 15
// Your Code's Output
// 15
// View Outputs Side By Side
// Input(s)
// {
//   "blueShirtSpeeds": [1, 2, 3, 4, 5],
//   "fastest": false,
//   "redShirtSpeeds": [5, 4, 3, 2, 1]
// }
// Test Case 16 passed!
// Expected Output
// 21
// Your Code's Output
// 21
// View Outputs Side By Side
// Input(s)
// {
//   "blueShirtSpeeds": [1, 2, 3, 4, 5],
//   "fastest": true,
//   "redShirtSpeeds": [5, 4, 3, 2, 1]
// }
// Test Case 17 passed!
// Expected Output
// 0
// Your Code's Output
// 0
// View Outputs Side By Side
// Input(s)
// {
//   "blueShirtSpeeds": [],
//   "fastest": true,
//   "redShirtSpeeds": []
// }