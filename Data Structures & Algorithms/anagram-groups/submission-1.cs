public class Solution {
    public string buildKey(string s) {
        int[] chars = new int[26];
        foreach(var c in s) {
            chars[c - 'a']++;
        }

        var keyBuilder = new StringBuilder();

        for (int i = 0; i < chars.Length; i++) {
            keyBuilder.Append(chars[i]);
            keyBuilder.Append(i + 'a');
        }

        return keyBuilder.ToString();
    }

    public List<List<string>> GroupAnagrams(string[] strs) {
        if (strs == null || strs.Length == 0) {
            return new List<List<string>>();
        }

        var dict = new Dictionary<string, List<string>>();

        foreach (var str in strs) {
            var key = buildKey(str);
            if (!dict.ContainsKey(key)) {
                dict[key] = new List<string>();
            }
            dict[key].Add(str);
        }

        return new List<List<string>>(dict.Values);
    }
}
