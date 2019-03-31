public class Solution {
    public int NumJewelsInStones(string J, string S) {
        var jewels = new HashSet<char>();
        foreach(var jewel in J) jewels.Add(jewel);
        int cnt = 0;
        foreach(var stone in S) {
            if(jewels.Contains(stone)) cnt++;
        }
        
        return cnt;
    }
}