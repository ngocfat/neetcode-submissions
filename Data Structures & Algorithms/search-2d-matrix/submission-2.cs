public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int m = matrix.Length;
            int n = matrix[0].Length;

                int left = 0;
                    int right = m - 1;

                        while (left <= right)
                            {
                                    int mid = left + (right - left) / 2;

                                            if (target < matrix[mid][0])
                                                    {
                                                                right = mid - 1;
                                                                        }
                                                                                else if (target > matrix[mid][n - 1])
                                                                                        {
                                                                                                    left = mid + 1;
                                                                                                            }
                                                                                                                    else
                                                                                                                            {
                                                                                                                                        left = 0;
                                                                                                                                                    right = n - 1;

                                                                                                                                                                while (left <= right)
                                                                                                                                                                            {
                                                                                                                                                                                            int col = left + (right - left) / 2;

                                                                                                                                                                                                            if (matrix[mid][col] == target)
                                                                                                                                                                                                                                return true;

                                                                                                                                                                                                                                                if (matrix[mid][col] < target)
                                                                                                                                                                                                                                                                    left = col + 1;
                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                        right = col - 1;
                                                                                                                                                                                                                                                                                                                    }

                                                                                                                                                                                                                                                                                                                                return false;
                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                            }

                                                                                                                                                                                                                                                                                                                                                return false;
                                                                                                                                                                                                                                                                                                                                                }
}
