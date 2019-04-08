// https://leetcode.com/problems/valid-palindrome-ii/
public class Solution {
    public bool ValidPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;
        while (left < right) {
            if (s[left] != s[right])
                return ValidPalindrome(s, left + 1, right) || ValidPalindrome(s, left, right - 1);
            left++;
            right--;
        }
        return true;
    }
    private static bool ValidPalindrome(string s, int left, int right) {
        while (left < right) {
            if (s[left++] != s[right--])
                return false;
        }
        return true;
    }
}