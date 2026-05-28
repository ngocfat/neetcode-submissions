class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        int t = s.size();
        int m = 0;
        int max_len = 0;
        int tmp = 0;
        unordered_map<char, int> maps;
        for (int i = 0; i < t; i++)
        {
            if (maps.find(s[i]) != maps.end() && maps[s[i]] >= m)
            {
                max_len = max(max_len, i - m);
                m = maps[s[i]] + 1; 
            }
            maps[s[i]] = i;
        }
        max_len = max(max_len, t - m);
        return max_len;
    }
};
