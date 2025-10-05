public class Solution {
    public int MajorityElement(int[] nums) {
         Dictionary<int, int> countMap = new Dictionary<int, int>();
    int n = nums.Length;

    foreach (int num in nums) {
        if (!countMap.ContainsKey(num)) {
            countMap[num] = 0;
        }
        countMap[num]++;

        if (countMap[num] > n / 2) {
            return num;
        }
    }
    return -1;
    }
}