
// O(1) time and space

// 258. Add Digits
public class AddDigits {
    public int AddDigitsMethod(int num) {
     int value = num;
     if(value< 9)
        return num;
    while(value>9)
        value = value.ToString().Sum(c => c - '0');
     return value;
    }
}

// Given an integer num, repeatedly add all its digits until the result has only one digit, and return it.

 

// Example 1:

// Input: num = 38
// Output: 2
// Explanation: The process is
// 38 --> 3 + 8 --> 11
// 11 --> 1 + 1 --> 2 
// Since 2 has only one digit, return it.
// Example 2:

// Input: num = 0
// Output: 0
 

// Constraints:

// 0 <= num <= 231 - 1
 

// Follow up: Could you do it without any loop/recursion in O(1) runtime?