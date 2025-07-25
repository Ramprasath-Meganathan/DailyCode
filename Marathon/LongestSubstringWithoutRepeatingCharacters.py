class Solution:
    #O(n2) time and O(m) space where m is the maximum size of substring
    def lengthOfLongestSubstring(self, s: str) -> int:
        n = len(s)
        longest = 0
        for i in range(n): # loop to indicate the start of the substring
            substring_set = set() 
            for j in range(i,n): #loop to find the end of the substring
                if s[j] in substring_set: #if character is already in the substring set
                    break
                substring_set.add(s[j])
            longest = max(longest,len(substring_set))
        return longest

    
    #O(n) time and O(m) space where m is the maximum size of substring
    def lengthOfLongestSubstring(self, s: str) -> int:
        n = len(s)
        longest = 0
        l= 0
        substring_set = set()
        for r in range(n):
            while s[r] in substring_set:
                substring_set.remove(s[l])
                l+=1  
            substring_set.add(s[r])
            longest = max(longest,len(substring_set))

        return longest

            

                
                