public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        
        // Look back on the previous day and determine whether or not it's worthwhile to make a trade.
        // Since we have infinite trades, it's always optimal to buy/sell as much as possible.
        for(int i = 1; i < prices.Length; i++) {
            if(prices[i] > prices[i-1]) {
                maxProfit += prices[i] - prices[i-1];
            }
        }
        
        return maxProfit;
    }
}