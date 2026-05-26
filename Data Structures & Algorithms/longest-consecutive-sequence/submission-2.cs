public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums == null || nums.Length == 0) return 0;
        var pq = new PriorityQueue<int, int>();
        
        for(int i = 0; i < nums.Length; i++) {
            pq.Enqueue(nums[i], nums[i]);
        }

        int max = 1;
        int consecutive = 1;
        int prev = pq.Dequeue();
        int now = 0;
        while(pq.Count > 0) {
            now = pq.Dequeue();
            if (now - prev == 1) {
                consecutive++;
                max = consecutive > max ? consecutive : max;
            }
            else if (now - prev >= 2) {
                consecutive = 1;
            }
            prev = now;
        }

        return max;
    }
}
