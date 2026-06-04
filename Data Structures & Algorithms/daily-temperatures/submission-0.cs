public class Solution {
    public int[] DailyTemperatures(int[] temps) {
        var stack = new Stack<int>();
        var res = new int[temps.Length];
        for(int i = 0; i<temps.Length; i++) {
            while(stack.Count>0 && temps[i]>temps[stack.Peek()]) {
                int k = stack.Pop();
                res[k]=i-k;
            }
            stack.Push(i);
        }
        return res;
    }
}
