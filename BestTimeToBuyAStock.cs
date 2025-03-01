public class BestTimeToBuyAStock {

    // O(n^2) time and O(1) space
     public int MaxProfit(int[] prices) {
    int difference = 0;
    for(int i=0;i<prices.Length-1;i++)
    {
       int counter=0;
       for(int j=i+1;j<prices.Length;j++)
       {
        if(prices[i]>prices[j])
        {
            if(counter==0)
                break;
            else
            {
            counter++;
            continue;
            }
        }
        if(prices[i]-prices[j]<difference)
            difference=prices[i]-prices[j];
       }
    }
    return Math.Abs(difference);
}

// O(n) time and O(1) space
    public int MaxProfitOptimized(int[] prices) {
        int minPrice = int.MaxValue;  // Track the lowest price seen so far
        int maxProfit = 0;            // Track the maximum profit

        foreach (int price in prices) {
            if (price < minPrice) {
                minPrice = price;  // Update minimum price if we find a lower one
            } else {
                maxProfit = Math.Max(maxProfit, price - minPrice);  // Check profit
            }
        }

        return maxProfit;
    }

    // O(n) time and O(1) space
    public int MaxProfitTwoPointer(int[] prices) {
        int left = 0, right = 1, maxProfit = 0;
        while(right<prices.Length)
        {
            if(prices[left]<prices[right])
            {
            int profit = prices[right] - prices[left];
            maxProfit = Math.Max(maxProfit, profit);
            }
            else
                left = right;
            right+=1;
        }
        return maxProfit;
}
}


// Problem statement
// You are given an array prices where prices[i] is the price of a given stock on the ith day.

// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.

// Return the maximum profit you can achieve from this transaction. If you cannot achieve any profit, return 0.

 
// Example 1:

// Input: prices = [7,1,5,3,6,4]
// Output: 5
// Explanation: Buy on day 2 (price = 1) and sell on day 5 (price = 6), profit = 6-1 = 5.
// Note that buying on day 2 and selling on day 1 is not allowed because you must buy before you sell.
// Example 2:

// Input: prices = [7,6,4,3,1]
// Output: 0
// Explanation: In this case, no transactions are done and the max profit = 0.
 

// Constraints:

// 1 <= prices.length <= 105
// 0 <= prices[i] <= 104