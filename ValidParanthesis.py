class Solution:
    def isValid(self, s: str) -> bool:
        stack = [] #O(n) time and O(n) space
        paranthesisDict = {']': '[',')':'(','}':'{'} #O(1) time and O(1) space
        for c in s: #O(n) time and O(1) space
            if c in paranthesisDict and len(stack)>0 and stack[-1] == paranthesisDict[c]: #O(1) time and O(1) space
                stack.pop() #O(1) time and O(1) space
            else: #O(1) time and O(1) space
                stack.append(c) #O(1) time and O(1) space
        return len(stack)==0 #O(1) time and O(1) space
    
    
                