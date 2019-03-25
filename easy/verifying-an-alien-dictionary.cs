// https://leetcode.com/problems/verifying-an-alien-dictionary/submissions/
public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        if (words == null || words.Length <= 1) return true;
        var orderLookup = new Dictionary<char, int>();
        for(int i = 0; i < order.Length; i++) {
            if(!orderLookup.ContainsKey(order[i])) {
                orderLookup.Add(order[i], i);
            }
        }
        
        for(int i = 1; i < words.Length; i++) {
            if (!IsLexo(orderLookup, words[i-1], words[i])) {
                return false;
            }
        }
        
        return true;
    }
    
    public bool IsLexo(Dictionary<char, int> lookup, string word1, string word2) {
        int j=0;
        for(int i = 0; i < word1.Length && j < word2.Length; i++, j++){
            var w1Lexo = lookup[word1[i]];
            var w2Lexo = lookup[word2[j]];
            //Console.WriteLine($"{word1[i]}, {word2[j]} " + w1Lexo + " -- "+ w2Lexo + " -- " + $"{w1Lexo > w2Lexo}");
            if(w1Lexo > w2Lexo) {
                return false;
            } else if(w2Lexo > w1Lexo) {
                return true;
            }
        }
        
        return false;
    }
}