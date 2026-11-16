public class Solution {
    public bool IsAnagram(string s, string t) {
        
if (s.Length != t.Length)
    {
        return false;
    }

char[] chars = s.ToCharArray();
char[] chars2 = t.ToCharArray();

 
Array.Sort(chars);
Array.Sort(chars2);

    for (int i = 0; i < chars.Length; i++)
    {
        if (chars[i] != chars2[i])
        {
            return false;
        }
        
    }

return true;

    }
}
