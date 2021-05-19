using System.Linq;

namespace Problems
{
    /**
     *  MultiplesArray
     *  Generates an array of length l where each value is the value of num
     *  multiplied by the index
     *  @param num [int] - Specified number to multiply each index by
     *  @param l [int] - Length of the array
     *  
     *  @return int[]
     */
    class Solution
    {
        public int[] MultiplesArray(int num, int l)
        {
            return Enumerable.Range(1,l).Select(x => x*num).ToArray();
        }
    }
}