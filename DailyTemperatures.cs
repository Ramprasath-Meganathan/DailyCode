public class DailyTemperatures {

    // Time complexity: O(n^2)
    // Space complexity: O(1)
    public int[] DailyTemperaturesMethod(int[] temperatures) {
        if(temperatures==null||temperatures.Length<=1)
            return new int[temperatures.Length]; // O(1) space
        for(int i = 0; i<temperatures.Length-1; i++) // O(n) time
        {
            int warmerDayCount = 0;
            bool found = false;
            for(int j = i+1; j<temperatures.Length; j++) // O(n) time
            {
                warmerDayCount++;
                if(temperatures[j]>temperatures[i])
                {
                    found = true;
                    temperatures[i]=warmerDayCount;
                    break;
                }
            }
               if(!found)
                    temperatures[i]=0;
        }
        temperatures[temperatures.Length-1] = 0;
        return temperatures;
    }

    // Time complexity: O(n)
    // Space complexity: O(n)
     public int[] DailyTemperaturesOptimized(int[] temperatures) {
      int length= temperatures.Length;
      var result  = new int[length]; // O(n) space
      Stack<int> stack = new Stack<int>(); // O(n) space
      for(int i = 0; i<length; i++) // O(n) time
      {
        while(stack.Count>0 && temperatures[i]>temperatures[stack.Peek()]) // O(1) time
        {
            int prevIndex = stack.Pop();
            result[prevIndex] = i - prevIndex;
        }
        stack.Push(i); // O(1) time
      }
      return result;
    }
}

// 739. Daily Temperatures
// Given an array of integers temperatures represents the daily temperatures, return an array answer such that answer[i] is the number of days you have to wait after the ith day to get a warmer temperature. If there is no future day for which this is possible, keep answer[i] == 0 instead.

 

// Example 1:

// Input: temperatures = [73,74,75,71,69,72,76,73]
// Output: [1,1,4,2,1,1,0,0]
// Example 2:

// Input: temperatures = [30,40,50,60]
// Output: [1,1,1,0]
// Example 3:

// Input: temperatures = [30,60,90]
// Output: [1,1,0]
 

// Constraints:

// 1 <= temperatures.length <= 105
// 30 <= temperatures[i] <= 100