public class Solution {
    public int RemoveElement(int[] nums, int val) {
        for(int i = 0; i<nums.Length - 1; i++)
        {
            if(nums[i] == val)
            {
                for(int j = i; j<nums.Length; j++)
                {
                    if(nums[j] != val)
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                        break;
                    }
                }
            }
        }
        int z = 0;
        for(int i = 0; i<nums.Length; i++)
        {
            if(nums[i] != val)
            {
                z++;
            }
        }
        
        return z;

    }
}