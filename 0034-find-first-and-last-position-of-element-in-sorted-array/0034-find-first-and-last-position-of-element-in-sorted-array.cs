public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int[] num = {-1,-1};
        for(int i = 0; i <= nums.Length - 1; i++)
        {
            if(nums[i] == target)
            {
                num[0] = i;
                break;
            }
        }
        for(int i = nums.Length - 1; i >= 0 ; i--)
        {
            if(nums[i] == target)
            {
                num[1] = i;
                break;
            }
        }

        return num;
    }
}