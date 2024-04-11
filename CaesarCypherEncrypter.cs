using System;

public class CaesarCypherEncryptorPgm {
  public static string CaesarCypherEncryptor(string str, int key) {
    char[] strArray = str.ToCharArray();
    int firstChar = ((int)'a');
    int lastChar = ((int)'z');
    int divisor = lastChar-firstChar+1;
    for(int letter= 0; letter< strArray.Length;letter++)
    {
    key = (key/divisor)<=0 && key%divisor!=0 ? key: key%divisor;
    int target = (int)strArray[letter]+key;
    int divisorValue = Math.Abs(target-lastChar) >= divisor ? target%divisor: target%lastChar-1;
    strArray[letter] = (target/lastChar>=1&&target!=lastChar) ? (char)(firstChar+(divisorValue)) : (char)target;
    }
    return new String(strArray);
  }
}
