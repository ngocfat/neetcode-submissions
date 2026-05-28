public class Solution {
    public int MaxProfit(int[] prices) {
        int pastMin = prices[0];
        int max = 0;
        for(int i = 1; i < prices.Length; i++) {
            int sub = prices[i] - pastMin;
            pastMin = sub < 0 ? prices[i] : pastMin;
            max = sub > max ? sub : max;
        }
        return max;
    }
}