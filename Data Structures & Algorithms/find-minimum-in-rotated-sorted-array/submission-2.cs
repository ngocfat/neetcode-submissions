public class Solution {
    public int FindMin(int[] nums) {
        if (nums[0] <= nums[nums.Length - 1]) return nums[0];
        int down = 0;
        int top = nums.Length - 1;
        int cursor = 0;
        while(true) {
            cursor = (top - down) / 2 + down;
            if (nums[cursor] > nums[nums.Length - 1]) {
                down = cursor+1;
            } else {
                if (nums[cursor] < nums[cursor-1]) return nums[cursor];
                top = cursor;
            } 
        }
        return 0;
    }
}
