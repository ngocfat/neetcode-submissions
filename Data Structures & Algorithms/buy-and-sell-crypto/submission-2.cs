public class Solution {
    public int MaxProfit(int[] prices) {
        int pastMin = prices[0];
        int max = 0;
        for(int i = 1; i < prices.Length; i++) {
            pastMin = prices[i] < pastMin ? prices[i] : pastMin;
            if (prices[i] - pastMin > max) {
                max = prices[i] - pastMin;
            }
        }
        return max;
    }
}