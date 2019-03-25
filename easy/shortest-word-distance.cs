// https://leetcode.com/problems/shortest-word-distance/submissions/
public class Solution {
    public int ShortestDistance(string[] words, string word1, string word2) {
        int min = int.MaxValue;
        
        int currWord1Index = int.MaxValue;
        int currWord2Index = int.MaxValue;
        for(int i = 0; i < words.Length; i++){
            if(words[i] == word1) {
                currWord1Index = i;
                if(currWord2Index != int.MaxValue){
                    min = Math.Min(min, Math.Abs(currWord1Index - currWord2Index));
                }
                
            } else if(words[i] == word2){
                currWord2Index = i;
                if(currWord1Index != int.MaxValue){
                    min = Math.Min(min, Math.Abs(currWord1Index - currWord2Index));
                }
            }
        }
        
        return min;
    }
}