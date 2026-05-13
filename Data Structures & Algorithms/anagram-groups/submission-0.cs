public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if (strs == null || strs.Length == 0) {
            return new List<List<string>>();
        }

        var dict = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++) {
            char[] chars = strs[i].ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!dict.ContainsKey(key)) {
                dict[key] = new List<string>();
            }
            dict[key].Add(strs[i]);
        }

        return new List<List<string>>(dict.Values);
    }
}
