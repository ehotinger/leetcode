// https://leetcode.com/problems/min-stack/submissions/
// The idea is to use 2x the memory to store the minimum alongside every element
public class MinStack {
    private Stack<int> stack;
    private int min;
    
    /** initialize your data structure here. */
    public MinStack() {
        stack = new Stack<int>();
        min = int.MaxValue;
    }
    
    public void Push(int x) {
        if (x <= min) {
            stack.Push(min);
            min = x;
        }
        stack.Push(x);
    }
    
    public void Pop() {
        if (stack.Pop() == min) {
            min = stack.Pop();
        }
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
        return min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */