// https://leetcode.com/problems/valid-palindrome-ii/

public class Solution {
    public bool ValidPalindrome(string s) {
        int i = 0;
        int j = s.Length-1;
        while(i < j) {
            if(s[i] != s[j]) {
                if(IsValidPalindrome(s.Remove(j,1)) || 
                    IsValidPalindrome(s.Remove(i,1))) {
                    return true;
                } else {
                    return false;
                }
            }
            j--;
            i++;
        }
        return true;
    }
    
    public bool IsValidPalindrome(string s) {
        for(int i = 0; i < s.Length/2; i++) {
            if(s[i] != s[s.Length-1-i]) {
                return false;
            }
        }
        return true;
    }
}

// A more memory-efficient version
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