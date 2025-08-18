class solution:
    #O(n.m) time and O(n) space
    #Sliding window approach
    def findAnagrams(self, s: str, p: str) -> List[int]:
        res = []                                   # Time: O(1) | Space: O(1)
        if len(p) > len(s):                        # Time: O(1) | Space: O(1)
            return []                              # Time: O(1) | Space: O(1)

        t_Count = Counter(p)                       # Time: O(m) | Space: O(σ)  (m=len(p), σ≤26)

        l, r = 0, len(p)                           # Time: O(1) | Space: O(1)

        while r < len(s):                          # Executes T = max(0, n-m) times (n=len(s))
            sub = s[l:r]                           # Time: O(m) | Space: O(m)  (string slice copies)
            sub_Count = Counter(sub)               # Time: O(m) | Space: O(σ)
            if sub_Count == t_Count:               # Time: O(σ) ≈ O(1) | Space: O(1)
                res.append(l)                      # Time: Amortized O(1) | Space: +O(1) per match
            l += 1                                 # Time: O(1) | Space: O(1)
            r += 1                                 # Time: O(1) | Space: O(1)

        return res                                 # Time: O(1) | Space: O(1)


    def findAnagrams(self, s: str, p: str) -> List[int]:
        #O(n) time and O(1) space
        m = len(s)
        n = len(p)
        res = []
        if n > m:
            return []
        p_Count = Counter(p)
        window = Counter(s[:n])
        if p_Count == window:
            res.append(0)
        for i in range(n,m):
            window[s[i]]+=1
            window[s[i-n]]-=1
            if window[s[i-n]]==0:
                del window[s[i-n]]
            if window == p_Count:
                res.append(i-n+1)
        return res