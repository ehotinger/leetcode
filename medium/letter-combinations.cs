// https://leetcode.com/problems/letter-combinations-of-a-phone-number/
public class Solution {
    public IList<string> LetterCombinations(string digits) {
        var ret = new List<string>();
        if (digits.Length == 0) return ret;
        Recurse(digits, "", 0, ret);
        return ret;
    }
    
    public void Recurse(string original, string built, int position, List<string> ret) {
        if(position == original.Length && built.Length == original.Length) {
            ret.Add(built);
        }
        
        for(int i = position; i < original.Length; i++) {
            var digit = original[i];
            foreach(var ltr in GetLetters(digit)) {
                Recurse(original, built + ltr, i+1, ret);
            }
        }
        
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