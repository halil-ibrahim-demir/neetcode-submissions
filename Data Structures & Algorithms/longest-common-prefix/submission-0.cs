public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        Array.Sort(strs);
        List<char> ortakHarfler = new List<char>();
        string first = strs[0];
        string last  =strs[strs.Length-1];

        int n = first.Length;
        if (last.Length < first.Length)
        {
            n = last.Length;
        }

        for (int i = 0; i < n; i++)
        {
            if (first[i] == last[i])
            {
                ortakHarfler.Add(first[i]);           
            }
            else
            {
                break;
            }
        }

        string ortakKelime = string.Concat(ortakHarfler);
        return ortakKelime;
    }
}