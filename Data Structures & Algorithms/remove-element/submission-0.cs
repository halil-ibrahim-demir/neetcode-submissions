public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        int indexDegeri = 0;

for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] != val)
    {
        nums[indexDegeri] = nums[i];
        indexDegeri ++;
    }
}

return indexDegeri;

    }
}