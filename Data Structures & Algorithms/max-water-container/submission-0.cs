public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length - 1;
        int max = 0;

        while (left < right) {
            int colL = heights[left];
            int colR = heights[right];
            int smaller = colL > colR ? colR : colL;
            int k = (right-left)*smaller;
            if (k > max) max = k;

            if (smaller == colL) left++;
            if (smaller == colR) right--;
        }

        return max;
    }
}
