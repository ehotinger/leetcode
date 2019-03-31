// https://leetcode.com/problems/compare-version-numbers/submissions/
public class Solution {
    public int CompareVersion(string version1, string version2) {
        var v1 = version1.Split('.');
        var v2 = version2.Split('.');

        var maxLen = Math.Max(v1.Length, v2.Length);
        
        for(var i = 0; i < maxLen; i++)
        {
            var tmp1 = i < v1.Length ? int.Parse(v1[i]) : 0;
            var tmp2 = i < v2.Length ? int.Parse(v2[i]) : 0;

            if(tmp1 > tmp2) return 1;
            if(tmp1 < tmp2) return -1;
        }

        return 0;
    }
}