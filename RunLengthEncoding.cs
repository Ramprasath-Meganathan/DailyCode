using System;

//O(n) time and O(n) space
public class RunLengthEncoding {
  public string RunLengthEncodingMethod(string str) {
    char currentElement = str[0];
    string finalString = "";
    int counter = 0;
    for(int i=0;i<str.Length;i++)
    {
        if(currentElement==str[i]&&counter<9)
            counter+=1;
        else
        {
            finalString+=counter.ToString()+currentElement.ToString();
            currentElement = str[i];
            counter=1;
        }
            
    }
   finalString+=counter.ToString()+currentElement.ToString();
    return finalString;
  }
}
