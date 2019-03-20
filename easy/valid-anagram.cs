using System;
using System.Collections;
using System.Collections.Generic;

public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        var dict = new Dictionary<char, int>();
        foreach(var c in s) {
            if(dict.ContainsKey(c)) {
                dict[c]++;
            } else {
                dict.Add(c, 1);
            }
        }
        
        foreach(var c in t) {
            if (dict.ContainsKey(c)) {
                dict[c]--;
            } else {
                return false;
            }
        }
        
        foreach(var key in dict.Keys){ 
            if(dict[key] != 0) return false;
        }
        
        return true;
    }
}