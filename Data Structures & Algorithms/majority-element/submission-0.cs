public class Solution {
    public int MajorityElement(int[] nums) {

    Array.Sort(nums);
    int mostUsed;
    mostUsed = nums[nums.Length / 2];

    return mostUsed;
        
    }
}