public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        HashSet<int> differentNums = new HashSet<int>();

foreach (var num in nums)
{
    bool hasIt = differentNums.Contains(num);
    differentNums.Add(num);

    if (hasIt)
    {
        return true;
    }
}

return false;
    }
}