class Solution {
public:
    double findMedianSortedArrays(vector<int>& nums1, vector<int>& nums2) {
        int m = nums1.size();
        int n = nums2.size();

        if (m == 0 && n == 0) return INT_MIN;

        if (m > n)
            return findMedianSortedArrays(nums2, nums1);
        int length_left = (m + n + 1) / 2; // length of left
        int left = 0, right = m;
        int i, j, tmp;

        while (left <= right)
        {
            tmp = left + right - 1;
            if (tmp < 0) i = -1;
            else i = tmp / 2;
            j = length_left - i - 2;
            int minL1 = i >= 0 ? nums1[i] : INT_MIN;
            int maxL1 = i + 1 < m ? nums1[i + 1] : INT_MAX;
            int minL2 = j >= 0 ? nums2[j] : INT_MIN;
            int maxL2 = j + 1 < n ? nums2[j + 1] : INT_MAX;

            if (minL1 > maxL2)
            {
                right = i;
            }
            else if (minL2 > maxL1)
            {
                left = i + 1;
            }
            else
            {
                if ((n + m) % 2 == 0) return (max(minL1, minL2) + min(maxL1, maxL2)) / 2.0f;
                else return max(minL1, minL2);
            }
        }

        return INT_MIN;
    }
};