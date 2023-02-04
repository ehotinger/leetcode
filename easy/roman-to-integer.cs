public class Solution 
{
    public int RomanToInt(string s) 
    {
          var result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0 && ConvertRomanToInt(s[i]) > ConvertRomanToInt(s[i - 1]))
                {
                    result += ConvertRomanToInt(s[i]) - ConvertRomanToInt(s[i - 1]) * 2;
                }
                else
                {
                    result += ConvertRomanToInt(s[i]);
                }
            }

            return result;
    }

    public int ConvertRomanToInt(char ch)
        {
            switch (ch)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: return 0;
            }
        }
}