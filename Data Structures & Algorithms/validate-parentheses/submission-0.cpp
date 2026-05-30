class Solution {
public:
    bool isValid(string s) {
        stack<char> st;
        for (char t : s)
        {
            if (t == '(') st.push(')');
            else if (t == '[') st.push(']');
            else if (t == '{') st.push('}');
            else
            {
                if (st.size() == 0) return false;
                if (st.top() != t) return false;
                st.pop();
            }
        }

        if (st.size() > 0) return false;
        return true;
    }
};
