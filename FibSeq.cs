using System;

public class Solution {

    // The initial solution for this problem can be done by return n for n = 0 or 1
    // then calculating the value by running through the sequence using a current, previous and temporary variable
    // this solution takes O(n) time and uses O(1) space
    
    public int Fib(int n) {
        if( n <= 1 ) { return n; }
        
        int prev = 0;
        int curr = 1;
        int i = 1;
        while( i < n ) {
            int tmp = curr + prev;
            prev = curr;
            curr = tmp;
            i++;
        }
        
        return curr;
    }
    
    // Mathematic Solve - O(1) time & space!
    
    // We can use the golden ratio to calculate the fibonacci sequence values with incredible accuracy
    // to do so we must first calculate the value of the golden ration (φ) = (1 + sqrt(5)) / 2 ~ 1.618
    // Then we can use that to find the value of the nth number in the sequence with the formula
    // (φ^n - ( 1 - φ )^n) / sqrt(5)
    // because we dont have a perfect calculator we will want to round whatever number we receive and then convert it to an integer
    
    public int FibMath(int n) {
        double golden = (1 + Math.Sqrt(5))/2;
        return (int) Math.Round((Math.Pow(golden, n) - Math.Pow(1 - golden, n))/Math.Sqrt(5));
    }
}
