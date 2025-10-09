public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) {
            if (set.Contains(nums[i])) {
                return true; // Found a duplicate within window
            }

            set.Add(nums[i]);

            // Keep the window size <= k
            if (set.Count > k) {
                set.Remove(nums[i - k]);
            }
        }

        return false;
    }
}