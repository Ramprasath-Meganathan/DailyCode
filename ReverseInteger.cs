// O(n) time and O(1) space
public class ReverseInteger {
    public int Reverse(int x) {
        var reverse = string.Join("", Math.Abs(x).ToString().Reverse());
        return int.Parse(reverse) * Math.Sign(x);
    }

// O(n) time and O(1) space
public int ReverseIntegerSoln2(int x) {
    long reversed = 0;
    int sign = x < 0 ? -1 : 1;
    x = Math.Abs(x);

    while (x > 0) {
        int pop = x % 10;
        x /= 10;

        // Check for overflow before multiplying
        if (reversed > (int.MaxValue - pop) / 10) {
            return 0; // Overflow
        }

        reversed = reversed * 10 + pop;
    }
    return (int)reversed * sign;
}
}



// Given a signed 32-bit integer x, return x with its digits reversed. If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.

// Assume the environment does not allow you to store 64-bit integers (signed or unsigned).

 

// Example 1:

// Input: x = 123
// Output: 321
// Example 2:

// Input: x = -123
// Output: -321
// Example 3:

// Input: x = 120
// Output: 21
 

// Constraints:

// -231 <= x <= 231 - 1