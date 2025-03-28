
// O(n) time and O(1) space
using System.Reflection.PortableExecutable;

public abstract class StringCompression
    {
        public virtual int Compress(char[] chars)
        {
            if (chars.Length <= 1)
            {
                return chars.Length;
            }

            int currItem = 0;
            char currentChar = chars[currItem];
            int nextItem = 1;
            int counter = 1;

            while (true)
            {
                if (nextItem > chars.Length)
                {
                    break;
                }

                if (nextItem == chars.Length || chars[nextItem] != currentChar)
                {
                    var prevChar = currentChar;
                    currentChar = chars[Math.Min(nextItem, chars.Length - 1)];

                    if (counter == 1)
                    {
                        chars[currItem++] = prevChar;
                    }
                    else
                    {
                        chars[currItem++] = prevChar;
                        string counterStr = counter.ToString();
                        foreach (var cstr in counterStr)
                        {
                            chars[currItem++] = cstr;
                        }
                    }

                    counter = 1;
                    nextItem++;
                    continue;
                }

                counter++;
                nextItem++;
            }

            return currItem;
        }
    }


    

// problem statement
//     Given an array of characters chars, compress it using the following algorithm:

// Begin with an empty string s. For each group of consecutive repeating characters in chars:

// If the group's length is 1, append the character to s.
// Otherwise, append the character followed by the group's length.
// The compressed string s should not be returned separately, but instead, be stored in the input character array chars. Note that group lengths that are 10 or longer will be split into multiple characters in chars.

// After you are done modifying the input array, return the new length of the array.

// You must write an algorithm that uses only constant extra space.

 

// Example 1:

// Input: chars = ["a","a","b","b","c","c","c"]
// Output: Return 6, and the first 6 characters of the input array should be: ["a","2","b","2","c","3"]
// Explanation: The groups are "aa", "bb", and "ccc". This compresses to "a2b2c3".
// Example 2:

// Input: chars = ["a"]
// Output: Return 1, and the first character of the input array should be: ["a"]
// Explanation: The only group is "a", which remains uncompressed since it's a single character.
// Example 3:

// Input: chars = ["a","b","b","b","b","b","b","b","b","b","b","b","b"]
// Output: Return 4, and the first 4 characters of the input array should be: ["a","b","1","2"].
// Explanation: The groups are "a" and "bbbbbbbbbbbb". This compresses to "ab12".
 

// Constraints:

// 1 <= chars.length <= 2000
// chars[i] is a lowercase English letter, uppercase English letter, digit, or symbol.