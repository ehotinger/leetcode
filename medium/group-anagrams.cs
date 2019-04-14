// https://leetcode.com/problems/group-anagrams/
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();
        
        // Group anagrams by sorting them by their alphabetical ordering.
        foreach(var str in strs) {
            var hash = new String(str.OrderBy(x => x).ToArray());
            if(dict.ContainsKey(hash)) {
                dict[hash].Add(str);
            } else {
                dict.Add(hash, new List<string>(){str});
            }
        }
        
        IList<IList<string>> ret = new List<IList<string>>();
        foreach(var key in dict.Keys) {
            ret.Add(dict[key]);
        }
        
        return ret;
    }
}