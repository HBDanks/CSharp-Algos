/*
You have a set of integers s, which originally contains all the numbers from 1 to n. Unfortunately, due to some error, one of the numbers in s got duplicated to another number in the set, which results in repetition of one number and loss of another number.

You are given an integer array nums representing the data status of this set after the error.

Find the number that occurs twice and the number that is missing and return them in the form of an array.
*/

public class Solution {
    
    // Going to practice using a Hashset here to get more comfortable with it after learning about it yesterday.
    public int[] FindErrorNums(int[] nums) {
        int dup = 0;
        int missing = 0;
        // initiate our hashset
        HashSet<int> items = new HashSet<int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            // if the hashset already contains an item
            // we have found our dup
            if(items.Contains(nums[i]))
            {
                dup = nums[i];
            }
            else
            {
                items.Add(nums[i]);
            }
        }
        
        for(int i = 1; i <= nums.Length; i++)
        {
            // if the hashset does not contain a number between 1 and nums.Length
            // we have found our missing item
            if(!items.Contains(i))
            {
                missing = i;
            }
        }
        
        return new int[]{dup, missing};
    }

    public int[] FindErrorNums2(int[] nums)
    {
        int dup = 0;
        int missing = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[Math.abs(nums[i]) - 1] < 0)
            {
                dup = Math.abs(nums[i]);
            }
            else
            {
                nums[Math.abs(nums[i]) - 1] *= -1;
            }
        }

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] > 0)
            {
                missing = i + 1;
            }
        }

        return new int[]{dup, missing};
    }
}