// https://leetcode.com/problems/decode-ways/
public class Solution {
    public static void Main(string[] args) {
        var ret = new List<string>();
        var word = "1123";
        Recurse(word, ret, "");
        Console.WriteLine(string.Join(" ", ret));
    }
    
    // Given a word 1123 find all permutations of the string
    // assuming 1..26 can be hashed from a..z
    
    // 1123
    // 1 + 123
    // 1 + 1 + 23       => aaw
    // 1 + 1 + 2 + 3    => aa b c
    // 11 + 23          => k w
    // 11 + 2 + 3       => k b c
    // 1 + 1 + 23       => a a w
    // etc.
    public void Recurse(string word, List<string> addTo, string builtSoFar) {
        if(word.Length == 0) return;
        if(word.Length <= 2) {
            if(IsValid(word)) {
                // A bit tricky: when we recurse, we only want to add the one hashed character, not the two
                addTo.Add(builtSoFar + Hash(word));
                Recurse(word.Substring(1), addTo, builtSoFar + Hash(word[0].ToString()));
            }
        } else {
            Recurse(word.Substring(1), addTo, builtSoFar + Hash(word[0].ToString()));
            Recurse(word.Substring(2), addTo, builtSoFar + Hash(word.Substring(0,2)));
        }
    }
    
    public bool IsValid(string s) {
        if(s.Length == 1 || 
           (s.Length == 2 && s[0] <= '2' && s[1] < '7')) {
            return true;
        }
        return false;
    }
    
    public string Hash(string s) {
        switch(s) {
            case "1":
                return "a";
            case "2":
                return "b";
            case "3":
                return "c";
            case "4":
                return "d";
            case "5":
                return "e";
            case "6":
                return "f";
            case "7":
                return "g";
            case "8":
                return "h";
            case "9":
                return "i";
            case "10":
                return "j";
            case "11":
                return "k";
            case "12":
                return "l";
            case "13":
                return "m";
            case "14":
                return "n";
            case "15":
                return "o";
            case "16":
                return "p";
            case "17":
                return "q";
            case "18":
                return "r";
            case "19":
                return "s";
            case "20":
                return "t";
            case "21":
                return "u";
            case "22":
                return "v";
            case "23":
                return "w";
            case "24":
                return "x";
            case "25":
                return "y";
            default: 
                return "z";
        }
    }
}