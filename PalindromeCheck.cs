using System;
using System.Text;

public class PalindromeCheck {

    // O(n2) time and O(n) space
  public static bool IsPalindrome(string str) {
    string originalString = str;
    var stringArray = originalString.ToCharArray();
    Array.Reverse(stringArray);
    if(new string(stringArray).Equals(str))
        return true;
    return false;
  }
    // O(n) time and O(n) space
    public static bool IsPalindromeSoln2(string str) {
    StringBuilder reversedString = new StringBuilder();
    for(int i=str.Length-1;i>=0;i--)
        reversedString.Append(str[i]);
    return str.Equals(reversedString.ToString());
  }
}