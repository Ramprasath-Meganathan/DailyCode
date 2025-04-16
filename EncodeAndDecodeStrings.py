class Solution:

    def encode(self, strs: List[str]) -> str:
        #O(L) time and OL) space where l is the length of all the characters in the list
        encoded = [] #O(1) time and O(n) space where n is the number of words
        for word in strs: #O(n) time and O(1) space
            encoded.append(f"{len(word)}#{word}") #O(1) time and O(M) space per append, total O(L) space
        return ''.join(encoded) #O(L) time and O(L) space

    def decode(self, s: str) -> List[str]:
        #O(L) time and O(L) space
        i = 0  #O(1) time and O(1) space
        decoded = []  #O(1) time and O(n) space
        while i < len(s):  #O(L) time and O(1) space
             j = i  #O(1) time and O(1) space
             while s[j]!='#': # #O(logL) time and O(1) space
                j+=1  #O(1) time and O(1) space
             length = int(s[i:j])  #O(logL) time and O(1) space
             j+=1  #O(1) time and O(1) space
             word = s[j:j+length]  #O(m) time and O(m) space per append
             decoded.append(word)  #O(1) time and O(m) space
             i = j+length  #O(1) time and O(1) space
        return decoded  #O(1) time and O(1) space
             
        