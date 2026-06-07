public class Solution {
    public int Search(int[] nums, int target) {
        if (nums.Length == 1 && nums[0] == target) return 0;
        int top = nums.Length - 1;
        int down = 0;
        
        while (down <= top) {
            int mid = (top - down) / 2 + down;
            if (nums[mid] == target) return mid;
            
            if (target >= nums[down]) { 
                if (nums[mid] > target) top = mid - 1;
                else {
                    if (nums[mid] < nums[down]) top = mid - 1;
                    else down = mid + 1;
                }
            } else {
                if (nums[mid] < target) down = mid + 1;
                else {
                    if (nums[mid] >= nums[down]) down = mid + 1;
                    else top = mid - 1;
                }
            }
        }
        return -1;
    }
}