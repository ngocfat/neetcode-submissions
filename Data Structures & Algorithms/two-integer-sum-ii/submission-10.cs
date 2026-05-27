public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int right = numbers.Length - 1;
        int left = 0;

        while (left <= right) {
            int sum = numbers[left] + numbers[right];
            if (sum == target)
            return new int[] {left+1,right+1};
            if (sum > target) right--;
            if (sum < target) left++;
        }
        
        return new int[0];
    }
}
