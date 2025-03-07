public class ValidParanthesis {
    public bool IsValid(string s) {
        if(s == null || s == string.Empty || s.Length ==1)
            return false;
        Dictionary<char,char> paranthesisDict = new Dictionary<char,char>(){
            {']','['},
            {'}','{'},
            {')','('}
        };
        Stack<char> stack= new Stack<char>();
        foreach(var c in s)
        {
            if(paranthesisDict.ContainsKey(c))
            {
                if(stack.Count==0||stack.Peek()==paranthesisDict[c])
                    stack.Pop();
                else
                    return false;
            }
            else
                stack.Push(c);
        }
        return true;
        
    }
}