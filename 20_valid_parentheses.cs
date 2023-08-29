public class Solution {
    public bool IsValid(string s) {
        
        Stack<char> stk = new Stack<char>();

        foreach(char c in s){
            if (c == '(') {
                stk.Push(')');
                continue;
            }
            if (c == '{') {
                stk.Push('}');
                continue;
            }
            if (c == '[') {
                stk.Push(']');
                continue;
            }
            if (stk.Count() == 0 || c != stk.Pop()) return false;
        }

        return stk.Count() == 0;

    }
}