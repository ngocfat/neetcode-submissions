public class Solution {
    public int Operation(int a, int b, string _operator) {
        switch(_operator) {
            case "+": return a + b;
            case "-": return a - b;
            case "*": return a * b;
            case "/": return a / b;
            default: return a + b;
        }
    }
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<string>();
        foreach(var token in tokens) {
            bool isOperator = token switch {
                "-" or "+" or "*" or "/" => true,
                _ => false,
            };
            if (isOperator) {
                int a = int.Parse(stack.Pop());
                int b = int.Parse(stack.Pop());
                stack.Push(Operation(b, a, token).ToString());
            } else {
                stack.Push(token);
            }
        }
        return int.Parse(stack.Pop());
    }
}
