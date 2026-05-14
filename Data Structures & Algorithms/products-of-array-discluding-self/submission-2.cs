public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return new int[0];
        }

        int[] result = new int[nums.Length];
        result[0] = 1;

        for(int i = 1; i < nums.Length; i++) {
            result[i] = result[i - 1] * nums[i-1];
        }

        int temp = nums[nums.Length - 1];
        for(int i = nums.Length - 2; i >= 0; i--) {
            result[i] *= temp;
            temp *= nums[i];
        }

        return result;
    }
}
