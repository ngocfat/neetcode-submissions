public class Solution {
    public bool Contains(List<List<int>> lists, List<int> add) {
        foreach (var list in lists)
        {
            if (list.Count != add.Count)
                continue;
            bool same = true;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != add[i])
                {
                    same = false;
                    break;
                }
            }
            if (same)
                return true;
        }
        return false;
    }

    public List<List<int>> ThreeSum(int[] nums) {
        var hash = new Dictionary<int, HashSet<int>>();
        var res = new List<List<int>>();
        for(int i = 0; i < nums.Length; i++) {
            if (!hash.ContainsKey(nums[i])) {
                hash[nums[i]] = new HashSet<int>();
            }
            hash[nums[i]].Add(i);
        } 
        for (int i = 0; i < nums.Length; i++) {
            int num = nums[i];
            int sub = 0 - num;
            for(int j = 0; j < nums.Length; j++) {
                if (j == i) continue;
                int tmp = sub - nums[j];
                if (hash.ContainsKey(tmp)) {
                    bool x = false;
                    bool containsI = hash[tmp].Contains(i);
                    bool containsJ = hash[tmp].Contains(j); 
                    if (hash[tmp].Count >= 3) x = true;
                    if (hash[tmp].Count == 2 && (!containsI || !containsJ)) x = true;
                    if (hash[tmp].Count == 1 && (!containsI && !containsJ)) x = true;
                    if (x) {
                        var list = new List<int>() { num, tmp, nums[j] };
                        list.Sort();
                        if (!Contains(res, list)) res.Add(list);
                    }
                }
            }
        }

        return res; 
    }
}
