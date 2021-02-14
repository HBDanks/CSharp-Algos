public class Solution {
    public int MySqrt(int x) {
        // first thought is just to use Math.sqrt
        // return (int) Math.Sqrt(x);

        // option 2: loop from 0 incrementing by 1 until we find the sqrt O(N)

        // option 3: binary search O(logN)
        if( x == 0)
        {
            return 0;
        }
        if ( x <= 3)
        {
            return 1;
        }
        int l = 0;
        int r = x;
        int m;
        while(l < r)
        {
            m =  (l + (int) ((r - l)/2));
            Console.WriteLine($"Left: {l}, Right: {r}, Squared: {(double) m * m}");
            if((double) m*m > (double) x)
            {
                r = m;
            }
            else if( m * m == x)
            {
                return m;
            }
            else 
            {
                l = m + 1;
            }
        }
        return l - 1;
    }
}