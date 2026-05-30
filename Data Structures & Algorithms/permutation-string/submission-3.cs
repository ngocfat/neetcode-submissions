public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int[] a = new int[26];
        int l = 0;
        int r = 0;
        foreach(var c in s1) a[c-'a']++;
        
        int[] b = new int[26];
        while(r < s2.Length) {
            b[s2[r]-'a']++;
            if(b[s2[r]-'a']>a[s2[r]-'a']) {
                while(s2[l]!=s2[r]) {
                    b[s2[l]-'a']--;
                    l++;
                }
                l++;
                if (b[s2[r]-'a']>=1)
                    b[s2[r]-'a']--;
            }
            if (r-l+1==s1.Length) return true;
            r++;
        }
        return false;
    }
}

