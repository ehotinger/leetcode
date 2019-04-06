public class Solution {
    public string AddBinary(string a, string b) {
        string ret = "";
        
        int aPtr = a.Length - 1;
        int bPtr = b.Length - 1;
        
        int carry = 0;
        while(aPtr >= 0 || bPtr >= 0) {
            var curr = 0;
            if (aPtr >= 0) {
                curr += a[aPtr] - '0';
            }
            if (bPtr >= 0) {
                curr += b[bPtr] - '0';
            }
            
            curr += carry;
            if(curr == 0 || curr == 2) {
                ret = "0" + ret;
            } else {
                ret = "1" + ret;
            }
            
            carry = curr > 1 ? 1 : 0;
            
            aPtr--;
            bPtr--;
        }
        if(carry == 1) {
            ret = "1" + ret;
        }
        
        return ret;
    }
}