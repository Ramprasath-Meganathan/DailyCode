public class IsSubsequence {
    public bool IsSubsequenceMethod(string s, string t) {
        if (s.Length == 0)
            return true;
        int sPointer = 0;
        for(int tPointer = 0; tPointer < t.Length; tPointer++)
        {
            if(t[tPointer] == s[sPointer])
                sPointer++;
            if(sPointer == s.Length)
                return true;
        }
        return false;
    }
}