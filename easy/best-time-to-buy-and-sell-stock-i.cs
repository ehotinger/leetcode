using System;

public class Solution {
    public int MaxProfit(int[] prices) {
        var maxProfit = 0;
        if(prices.Length == 0) return 0;
        
        // Go through all prices, keeping track of the smallest (day to buy)
        // and compute the max profit as we go along
        var currMin = prices[0];
        for(int i = 0; i < prices.Length; i++) {
            currMin = Math.Min(currMin, prices[i]);
            maxProfit = Math.Max(maxProfit, prices[i] - currMin);
        }
        
        return maxProfit;
    }
}