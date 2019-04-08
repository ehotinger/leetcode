// https://leetcode.com/problems/letter-combinations-of-a-phone-number/
public class Solution {
    public IList<string> LetterCombinations(string digits) {
        IList<string> curr = new List<string>();
        if (digits.Length == 0) return curr;

        curr.Add("");
        foreach (char d in digits)
        {
            IList<string> next = new List<string>();
            foreach (char letter in GetLetters(d))
            {
                foreach (string s in curr)
                {
                    next.Add(s + letter);
                    //Console.WriteLine(string.Join(" ", next));
                }
            }
            curr = next;
            //Console.WriteLine("--------");
        }
        return curr;
    }

    public char[] GetLetters(char digit)
    {
        switch (digit)
        {
            case '2':
                return new char[] { 'a', 'b', 'c' };
            case '3':
                return new char[] { 'd', 'e', 'f' };
            case '4':
                return new char[] { 'g', 'h', 'i' };
            case '5':
                return new char[] { 'j', 'k', 'l' };
            case '6':
                return new char[] { 'm', 'n', 'o' };
            case '7':
                return new char[] { 'p', 'q', 'r', 's' };
            case '8':
                return new char[] { 't', 'u', 'v' };
            case '9':
                return new char[] { 'w', 'x', 'y', 'z' };
            default:
                return new char[0];
        }
    }
}