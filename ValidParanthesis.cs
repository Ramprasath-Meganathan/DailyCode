public class ValidParanthesis {
    // O(n) time and O(n) space
    public bool IsValid(string s) {
    Stack<char> stack = new Stack<char>(); // O(n) space O(1) time
    if(s == null || s.Length %2 != 0) // O(1) timespace
        return false; // O(1) time
       var paranthesisDict = new Dictionary<char,char>(){{ 
        ')','('
       },{'}','{'},{']','['}}; //O(1) space
       foreach(var c in s) //O(n) time
       {
        if(paranthesisDict.ContainsKey(c)) //O(1) time
        {
        if (stack.Count == 0 || stack.Pop() != paranthesisDict[c]) //O(1) time
            return false; //O(1) time
         }
        else
            stack.Push(c);//O(n) time
       }
       return stack.Count == 0; //O(1) time
        
    }

// O(n^2) time and O(1) space
    public bool IsValidUnOptimized(string s) {
    if(s==null||s.Length %2!=0)
        return false;
    while(s.Contains("()")||s.Contains("[]")||s.Contains("{}"))
        s = s.Replace("()","").Replace("[]","").Replace("{}","");
    return s.Length == 0;
    }
}