using System.Xml.XPath;

namespace DailyCode;

class Program
{
    static void Main(string[] args)
    {


        // List<int> array =  [5,1,22,25,6,-1,8,10];
        // List<int> array = [1,1,6,1];
        // List<int> sequence = [1, 1, 1, 6];
        //     List<int> sequence = [5, 1, 22, 22, 6, -1, 8, 10];
        //     int [,] matrix = new int[,]{{1,2}};
        //    int rowLength = matrix.GetLength(0);  //1
        // int colLength = matrix.GetLength(1); //2
        // int[,] outputMatrix = new int[colLength,rowLength];  
        // int j=0;
        //      for(int i=0;i<rowLength;i++)
        // {
        //     for(j=0;j<colLength;j++)
        //     {
        //         outputMatrix[j,i] = matrix[i,j];
        //     }
        // }
        // var strings = new string[7]{"abcde", "aa", "foobar", "foobaz", "and this is a string", "aaaaaaaa", "eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeea"};
        // Console.Write(CommonCharacters(strings));
        // List<int> array = [2, 1, 2, 2, 2, 3, 4, 2];
        // int[] prices =[7,1,5,3,6,4];
        // int x = MaxProfit(prices);
        //SmallestDifference(arrayOne,arrayTwo);
        // int[] array = [2,1,5,2,3,3,4];
        // var  b = IsPalindrome( "ab_a");
        // int k = KthFactor(7,2);
        //  char[] ints = new char[6]{"a","b","b","b","b","b","b","b","b","b","b","b","b"};
        // Console.Write(Compress(ints));
        // string[] abc = ["d","b","c","b","c","a"];
        // int i = StrStr("aadbutsad","sad");
        // RemoveDuplicatesInLinkedList.ListNode l1 = new RemoveDuplicatesInLinkedList.ListNode(1,new RemoveDuplicatesInLinkedList.ListNode(1,new RemoveDuplicatesInLinkedList.ListNode(2,null)));
        // RemoveDuplicatesInLinkedList.DeleteDuplicates(l1);
        // int[] ints = { 1, 2,3};
        // Console.Write(PlusOne(ints));
        // string[] str = ["eat","tea","tan","ate","nat","bat"];
        // var boole = GroupAnagrams.GroupAnagramsSolution(str);

        // Example usage
        string str1 = "pales";
        string str2 = "pale";
        //string result = URLify.URLifyMethod("Mr John Smith    ", 13);
        // bool result = PermutationString.PermutationStringSolution2(str1,str2);
        //   var instance =  new CompressStringUpFront();
        //   var result = instance.Compress("aaabcccccaaa");
        // var instance = new PalindromeChecker();
        // var result = instance.PalindromeChekerInMemory("annas");
        LinkedListCRUD crud = new LinkedListCRUD();
        var list = crud.CreateLinkedList([1,2,3,4,5]);
        crud.PrintLinkedList(crud.AppendNodeToTail(list,6));
        var PrintKthToLast = new PrintKthToLast().PrintKthToLastTwoPointers(list,2);
        // var removedupesInstance = new RemoveLinkedListDuplicates();
        // crud.PrintLinkedList(removedupesInstance.RemoveDuplicates(list));
        // crud.PrintLinkedList(crud.DeleteLinkedListNode(list,4));
        // Console.Write(result);
    }

    public static bool IsPalindrome(string input)
    {
        if (input == null) throw new ArgumentNullException(nameof(input));

        try
        {
            // Remove spaces and punctuation, and convert to lower case.
            var processedInput = new string(Array.FindAll(input.ToCharArray(), char.IsLetterOrDigit));
            processedInput = processedInput.ToLowerInvariant();

            // Check if the processed string is a palindrome.
            int left = 0;
            int right = processedInput.Length - 1;
            while (left < right)
            {
                if (processedInput[left] != processedInput[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }
        catch (Exception ex)
        {
            // Handle potential exceptions, such as index out of range.
            Console.WriteLine($"An error occurred: {ex.Message}");
            return false;
        }
    }



    public static bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> counter = new Dictionary<char, int>();
        foreach (var x in magazine)
        {
            if (counter.ContainsKey(x))
                counter[x] += 1;
            else
                counter[x] = 1;
        }
        foreach (var ch in ransomNote)
        {
            if (!counter.ContainsKey(ch))
                return false;
            else
                counter[ch] = counter[ch] - 1;
        }
        return counter.Values.Any(x => x < 0);
    }

    public static int SearchInsert(int[] nums, int target)
    {
        int previousDiffValue = Math.Abs(nums[0] - target);
        int currentDiffValue = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            currentDiffValue = Math.Abs(nums[i] - target);
            if (currentDiffValue < previousDiffValue && currentDiffValue != 0)
            {
                previousDiffValue = currentDiffValue;
            }
            else
                return i;
        }
        return nums.Length;
    }
    // or 
    // int lengthToTraverse = index/2;
    // for(int i = 0; i <= lengthToTraverse; i++)
    // {
    //     var temp = wordArray[i];
    //     wordArray[i] = wordArray[index];
    //     wordArray[index] = temp;
    //     index--;
    // }

    public static int[] PlusOne(int[] digits)
    {
        string intValue = "";
        for (int i = 0; i < digits.Length; i++)
        {
            intValue += digits[i];
        }
        int j = Convert.ToInt32(intValue) + 1;
        var y = j.ToString().ToCharArray();
        int[] zp = y.Select(a => a - '0').ToArray();
        return zp;
    }

    public static int Compress(char[] chars)
    {
        int counter = 0;
        char currentChar = '\0';
        char previousChar = '\0';
        int resultIndex = 0;
        foreach (var c in chars)
        {
            currentChar = c;
            if (previousChar == '\0')
            {
                previousChar = c;
                counter = 1;
                continue;
            }
            if (previousChar != currentChar)
            {
                chars[resultIndex] = previousChar;
                if (counter > 1)
                {
                    chars[resultIndex + 1] = (char)(counter + '0');
                    resultIndex += 2;
                    counter = 1;
                }
                else
                    resultIndex += 1;
                previousChar = currentChar;

            }
            else
                counter += 1;
        }
        chars[resultIndex] = previousChar;
        chars[resultIndex + 1] = (char)(counter + '0');

        Array.Resize(ref chars, resultIndex + 1);
        return chars.Length;
    }

    public static int StrStr(string haystack, string needle)
    {
        if (needle == "")
            return 0;
        for (int i = 0; i < haystack.Length + 1 - needle.Length; i++)
        {
            for (int j = 0; j < needle.Length; j++)
            {
                if (haystack[i + j] != needle[j])
                    break;
                if (j == needle.Length - 1)
                    return i;
            }
        }
        return -1;
    }

}
