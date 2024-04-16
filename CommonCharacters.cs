using System;
using System.Collections.Generic;
using System.Linq;

public class CommonCharactersPgm {
//O(n) time and O(1) space
  public string[] CommonCharacters(string[] strings) {
    Dictionary<char,int> commonCharList = new Dictionary<char,int>();
    int charCountMax = strings.Length;
    for(int i=0;i<charCountMax;i++)
    {
        var currentString = strings[i].ToCharArray();
        foreach(var c in currentString)
        {
            if(i==0)
                 commonCharList[c] = 1;
            else if (commonCharList.ContainsKey(c) && commonCharList[c]-i==0)
               commonCharList[c]+=1;
        }             
    }  
   return commonCharList.Where(x=>x.Value==charCountMax).Select(x=>x.Key.ToString()).ToArray();
  }
}
