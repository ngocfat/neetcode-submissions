public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        if (nums == null || nums.Length == 0) {
            return new int[0];
        }

        List<int> result = new List<int>();
        var countDict = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) {
            if (!countDict.ContainsKey(nums[i])) {
                countDict[nums[i]] = 0;
            }
            countDict[nums[i]]++;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach(var pair in countDict) {
            var freq = pair.Value;
            if (buckets[freq] == null) {
                buckets[freq] = new List<int>();
            }
            buckets[freq].Add(pair.Key);
        }
        
        for(int i = buckets.Length - 1; i > 0 && result.Count < k; i--) {
            if (buckets[i] == null) continue;
            foreach(var num in buckets[i]) {
                result.Add(num);
                if (result.Count == k) break;
            }
        }

        return result.ToArray();
    }
}
