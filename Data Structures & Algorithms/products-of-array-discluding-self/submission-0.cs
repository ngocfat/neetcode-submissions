public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return new int[0];
        }

        var numOfZero = 0;
        int multiple = nums[0];
        for(int i = 1; i < nums.Length; i++) {
            if (nums[i] == 0) {
                numOfZero++;
                continue;
            }
            multiple *= nums[i];
        }

        int[] result = new int[nums.Length];
        for(int i = 0; i < nums.Length; i++) {
            if (nums[i] == 0) {
                if (numOfZero > 1) result[i] = 0;
                else result[i] = multiple;
            }
            else {
                if (numOfZero > 0) result[i] = 0;
                else result[i] = multiple / nums[i];
            }
        }
        return result;
    }
}
