public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        if (numbers.Length == 2) {
            if (numbers[0] + numbers[1] == target)
                return new int[] { 1, 2};
            return new int[0];
        }

        int t = 0;
        for(int i = 0; i < numbers.Length; i++) {
            t = i;
            if (numbers[i] + numbers[i+1] >= target) break;
        }

        int left = t;
        int right = t+1;

        while(right < numbers.Length && left >= 0) {
            int sum = numbers[left] + numbers[right];
            if (sum == target) 
                return new int[] { left + 1, right + 1 };
            
            if (sum > target) left--;
            if (sum < target) right++;
        }

        return new int[0];
    }
}
