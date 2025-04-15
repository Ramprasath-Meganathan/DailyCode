#Group Anagrams
# Given an array of strings, group the anagrams together. You can return the answer in any order.
class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        #O(n*mlogm) time and O(n) space where n is the number of unique pairs in the result
        anagramDict = {} #O(n) space where n is the number of different pairs and O(1) time
        for word in strs: #O(n) time and O(1) space
            sortedWord = ''.join(sorted(word)) #O(mlogm) where m is the length of the longest string in the strs list O(m) space
            if sortedWord not in anagramDict: #O(1) time and O(1) space
                anagramDict[sortedWord] = [] #O(1) time and O(n) space
            anagramDict[sortedWord].append(word) #O(1) time and O(1) space
        return list(anagramDict.values()) #O(n) time and O(n) space


    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        #O(n*mlogm) time and O(m) space
        anagramDict = defaultdict(list) #initialize default values of list if key is not present #O(1) time and O(n) space
        for word in strs: #O(n) time and O(1) space
            sortedString = ''.join(sorted(word)) #O(mlogm) time and O(m) space
            anagramDict[sortedString].append(word) # O(1) time and O(1) space
        return list(anagramDict.values()) #O(n) time and O(n) space 
