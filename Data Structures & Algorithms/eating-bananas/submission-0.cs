public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int left = 1;
        int right = piles.Max();

        while (left < right)
        {
            int mid = left + (right - left) / 2;
            long hours = 0;
            foreach (int pile in piles)
            {
                hours += (pile + mid - 1) / mid;
            }
            if (hours <= h)
                right = mid;
            else
                left = mid + 1;
        }
        return left;
    }
}