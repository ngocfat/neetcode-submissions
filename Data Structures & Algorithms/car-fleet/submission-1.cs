public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        Array.Sort(position, speed); 
        var stack = new Stack<float>();
        for(int i = 0; i < position.Length; i++){
            float s = (float)(target - position[i]) / speed[i];
            while(stack.Count > 0 && s >= stack.Peek()) {
                stack.Pop();
            }
            stack.Push(s);
        }
        return stack.Count;
    }
}
