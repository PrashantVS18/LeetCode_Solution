public class Solution {
    public string CountAndSay(int n) {
        string curr = "1"; // base case

        for (int k = 2; k <= n; k++) {
            string next = "";
            int count = 1;

            for (int i = 1; i <= curr.Length; i++) {
                // if current char same as previous, increase count
                if (i < curr.Length && curr[i] == curr[i - 1]) {
                    count++;
                } else {
                    // when different or end reached, say it
                    next += count.ToString() + curr[i - 1];
                    count = 1;
                }
            }

            curr = next; // update for next iteration
        }

        return curr;
    }
    
}