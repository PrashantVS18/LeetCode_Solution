public class Solution {
    public int MaxArea(int[] height) {

     int left = 0;
     int right = height.Length - 1;

     int width = 0;
     int maxarea = 0;

     while (left < right)
     {

        width = right - left;
        int area = width * Math.Min(height[left],height[right]);
        if(area > maxarea)
        {
            maxarea = area;
        }

        if(height[left] > height[right])
        {
            right--;
        }
        else
        {
            left++;
        }

     }

     return maxarea;

        
    }
}