public static class OneAway
{

    // O(n) time and O(1) space
    public  static bool OneEditAway(string s1, string s2)
    {
        if(s1.Length == s2.Length)
          return OneEditReplace(s1, s2);
        else if(s1.Length < s2.Length)
          return OneEditInsert(s1,s2);
        else
          return OneEditInsert(s2,s1);
    }

    public static bool OneEditReplace(string s1, string s2)
    {
        bool foundDifference = false;
        for(int i = 0; i < s1.Length; i++)
        {
            if(s1[i]!=s2[i])
            {
                if(foundDifference)
                    return false;
                foundDifference = true;  
            }    
        }
        return foundDifference;
    }

    public static bool OneEditInsert(string s1, string s2)
    {
        int index1=0, index2=0;
        while(index2<s2.Length&& index1<s1.Length)
        {
            if(s1[index1]!=s2[index1])
            {
                if(index1 != index2)
                    return false;
                index2++;
            }
            else
            {
                index1++;
                index2++;
            }
        }
        return true;
    }
}