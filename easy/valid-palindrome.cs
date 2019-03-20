public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;
        
        while (left < right)
        {
            if (!char.IsLetterOrDigit(s[left]))
                left++;
            else if (!char.IsLetterOrDigit(s[right]))
                right--;
            else if (char.ToUpperInvariant(s[left]) != char.ToUpperInvariant(s[right]))
                return false;
            else
            {
                left++;
                right--;
            }
        }
        
        return true;
    }
}