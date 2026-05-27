public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums == null || nums.Length == 0) return 0;

        var dict = new Dictionary<int, bool>();
        foreach(int num in nums) {
            dict[num] = false;
        }

        int max = 1;
        int cons = 1;
        int left = 0;
        int right = 0;
        foreach(int num in nums) {
            if (dict[num]) continue;
            dict[num] = true;
            left = right = num;
    
            while(dict.ContainsKey(left-1)) {
                left--;
                cons++;
                dict[left] = true;
            }

            while(dict.ContainsKey(right+1)) {
                right++;
                cons++;
                dict[right] = true;
            }

            if (cons > max) {
                max = cons;
            }

            cons = 1;
        }

        return max;
    }
}
