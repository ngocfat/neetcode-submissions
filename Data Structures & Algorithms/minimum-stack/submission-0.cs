public class MinStack {
    Stack<int> stack;
    Stack<int> min;

    public MinStack() {
        stack = new Stack<int>();
        min = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if (min.Count == 0 || val <= min.Peek()) {
            min.Push(val);
        }
        else {
            min.Push(min.Peek());
        }
    }
    
    public void Pop() {
        int p = stack.Pop();
        min.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return min.Peek();
    }
}
