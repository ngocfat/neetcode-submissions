public class Solution {

    public string Encode(IList<string> strs) {
        var encode = new StringBuilder();
        foreach(var str in strs) {
            encode.Append(str.Length).Append("#").Append(str);
        }
        return encode.ToString();
    }

    public List<string> Decode(string s) {
        var decode = new List<string>();
        int i = 0;
        while(i < s.Length) {
            int j = i;
            while(s[j] != '#') {
                j++;
            }
            int num = int.Parse(s.Substring(i, j - i));
            i = j + 1;
            decode.Add(s.Substring(i, num));
            i += num;
        }
        return decode;
    }
}
