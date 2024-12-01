public static class URLify
{
    // O(n) time  where n is the true length of the string
    public static string URLifyMethod(string str, int trueLength)
    {
        char[] strCharArray = str.ToCharArray();
        int spaceCounter=0, index, i = 0;
        for(i = 0; i < trueLength; i++)
        {
            if(str[i]==' ')
              spaceCounter++;
        }
        index = trueLength + spaceCounter*2;
        if(trueLength<str.Length)
             strCharArray[trueLength] = '\0';
        for(i = trueLength -1 ; i >= 0 ; i--)
        {
            if(str[i]==' ')
            {
                strCharArray[index -1] = '0';
                strCharArray[index-2] = '2';
                strCharArray[index-3] = '%';
                index = index - 3;
            }
            else
            {
                strCharArray[index-1] = str[i];
                index--;
            }
        }
        return new string(strCharArray);
    }
}

// Test case     string result = URLify.URLifyMethod("Mr John Smith    ", 13);
// should return Mr%20John%20Smith