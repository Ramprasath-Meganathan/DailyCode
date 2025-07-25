class Solution:
    #brute force solution
    def frequencySort(self, s: str) -> str:
        #O(n+klogk) time and O(n) space where n is the length of the string 
        counterDict = {}
        s1=[]
        for c in s:
            #O(n) time and O(k) space  where k is the number of unique keys in dictionary
            counterDict[c]=1+counterDict.get(c,0) #getting the frequency of the characters
            #O(klogk) time and O(k) space where k is the number of unique keys. 
        reverseDict = dict(sorted(counterDict.items(),key = lambda x:x[1], reverse=True)) #reverse them a create a new dictionary
        #O(n) time and O(n) space 
        for key,value in reverseDict.items(): #create a new string based on the frequency
               s1.extend([key]*value)
        return ''.join(s1)

#
def frequencySort(self, s: str) -> str:
        #O(n) time and O(n) space
       counter = Counter(s) #get the frequency O(n) time and O(k) space
       buckets = defaultdict(list) #O(k) space where k is the number of unique count of strings
       for k,v in counter.items(): #O(k) time where k is the frequency of unique characters
            buckets[v].append(k) 
       res = []
       for i in range(len(s),0,-1): #O(n) iterations where n is the frequency of unique characters
            for c in buckets[i]: #O(k) in total across all iterations
                res.append(c*i) #O(i) for this append
            
       return ''.join(res) #O(n) time and O(n) space

# 451. Sort Characters By Frequency
# Given a string s, sort it in decreasing order based on the frequency of the characters. The frequency of a character is the number of times it appears in the string.

# Return the sorted string. If there are multiple answers, return any of them.

 

# Example 1:

# Input: s = "tree"
# Output: "eert"
# Explanation: 'e' appears twice while 'r' and 't' both appear once.
# So 'e' must appear before both 'r' and 't'. Therefore "eetr" is also a valid answer.
# Example 2:

# Input: s = "cccaaa"
# Output: "aaaccc"
# Explanation: Both 'c' and 'a' appear three times, so both "cccaaa" and "aaaccc" are valid answers.
# Note that "cacaca" is incorrect, as the same characters must be together.
# Example 3:

# Input: s = "Aabb"
# Output: "bbAa"
# Explanation: "bbaA" is also a valid answer, but "Aabb" is incorrect.
# Note that 'A' and 'a' are treated as two different characters.
 

# Constraints:

# 1 <= s.length <= 5 * 105
# s consists of uppercase and lowercase English letters and digits.