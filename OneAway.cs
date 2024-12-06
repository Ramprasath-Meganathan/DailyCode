using System.Security.Cryptography;

public class OneAway
{

    // O(n) time and O(1) space
    public virtual bool OneEditAway(string s1, string s2)
    {
        if(s1.Length == s2.Length)
          return OneEditReplace(s1, s2);
        else if(s1.Length < s2.Length)
          return OneEditInsert(s1,s2);
        else
          return OneEditInsert(s2,s1);
    }

    private bool OneEditReplace(string s1, string s2)
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

    private bool OneEditInsert(string s1, string s2)
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

// O(n) time and O(1) space
public class OneAwaySolution2: OneAway
{
  public override bool OneEditAway(string first, string second)
    {
        if(Math.Abs(first.Length-second.Length)>1)
            return false;
        int index1= 0, index2 = 0;
        bool foundDifference = false;

        string s1 = first.Length < second.Length ? first : second;
        string s2 = first.Length < second.Length ? second: first;

        while(s2.Length<index2 && s1.Length< index1)
        {
            if(s1[index1] != s2[index2])
            {
                if(foundDifference)
                    return false;
                foundDifference = true;

                if(s1.Length == s2.Length)
                    index1++;
            }
            else
            {
                index1++;
            }
            index2++;
        }
        return true; 
    }
}