public class Solution {
    public int CharacterReplacement(string s, int k) {
        int max = 0;
        for(int i = 0; i < s.Length; i++) {
            char m = s[i];
            int t = k;
            int j = i;
            int tmp = 0;
            while(j < s.Length) {
                if (s[j] == m) {
                    tmp++;
                    j++;
                    continue;
                } else if (t == 0) break;
                tmp++;
                if (t == 0) break;
                t--;
                j++;
            }
            if (t > 0) {
                tmp += t; 
            }
            if (tmp > max) max = tmp;
        }
        return max > s.Length ? s.Length : max;
    }
}
