public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        int[] chars = new int[26];
        foreach (char c in s) {
            chars[c - 'a']++;
        }
        foreach (char c in t) {
            if (--chars[c - 'a'] == -1)
                return false;
        }
        
        foreach (int count in chars) {
            if (count != 0) return false;
        }

        return true;
    }
}
