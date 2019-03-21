public class Solution {
    public bool IsValid(string s) {
        // Maintain a stack of the characters, any time we hit a closing parenthesis, pop from the stack
        // and make sure that the popped value is the correct opening parenthesis.
        var stack = new Stack<char>();
        foreach(var c in s) {
            char pop;
            
            // For a case like "]})"
            if((c == ')' || c == '}' || c==']') && stack.Count == 0) return false;
            
            switch(c) {
                case ')':
                    pop = stack.Pop();
                    if(pop != '(') {
                        return false;
                    }
                    break;
                case '}':
                    pop = stack.Pop();
                    if(pop != '{') {
                        return false;
                    }
                    break;
                case ']':
                    pop = stack.Pop();
                    if(pop != '[') {
                        return false;
                    }
                    break;
                default:
                    stack.Push(c);
                    break;
            }
        }
        
        return stack.Count == 0;
    }
}