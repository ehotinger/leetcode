// https://leetcode.com/problems/task-scheduler/
public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        var dict = new Dictionary<char, int>();
        var lastUsed = new Dictionary<char, int>(); 
        foreach(var task in tasks) {
            if(dict.ContainsKey(task)) {
                dict[task]++;
            } else {
                dict.Add(task, 1);
                lastUsed.Add(task, int.MinValue);
            }
        }
                
        int interval = 0;
        while(dict.Count > 0) {
            var most = 0;
            char mostKey = ' ';
            // NB: optimize with heap
            foreach(var key in dict.Keys) {
                if(dict[key] > most && lastUsed[key] < interval - n) {
                    mostKey = key;
                    most = dict[key];
                }
            }
            
            if(mostKey == ' ') {
                interval++;
                continue;
            }
            
            if(dict[mostKey] == 1) {
                dict.Remove(mostKey);
                lastUsed.Remove(mostKey);
            } else {
                dict[mostKey]--;
                lastUsed[mostKey] = interval;
            }
            
            interval++;
        }
        
        return interval;
    }
}