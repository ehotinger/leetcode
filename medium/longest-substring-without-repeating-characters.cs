public class Solution {
    // Maintain a range [i,j], shift i if we hit a duplicate character at j.
    // Keep track of all the used characters as we go along.
    public int LengthOfLongestSubstring(string s) {
        var longest = 0;
        var usedChars = new HashSet<char>();
        int i = 0, j = 0;
        
        while (i < s.Length && j < s.Length) {
            if(usedChars.Contains(s[j])) {
                usedChars.Remove(s[i++]);
            } else {
                usedChars.Add(s[j++]);
                longest = Math.Max(longest, j-i);
            }
        }
        
        return longest;
    }
}