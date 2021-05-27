using System;
public class Solution {
    public int MinPartitions(string n) {
        int max = 0;
        
        foreach(char c in n)
        {
            // Subracting the character '0' will return the difference in ascii values
            int num = c - '0';
            max = Math.Max(num, max);
        }
        
        return max;
    }
}