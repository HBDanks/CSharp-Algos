/*
Alice has n candies, where the ith candy is of type candyType[i]. Alice noticed that she started to gain weight, so she visited a doctor.

The doctor advised Alice to only eat n / 2 of the candies she has (n is always even). Alice likes her candies very much, and she wants to eat the maximum number of different types of candies while still following the doctor's advice.

Given the integer array candyType of length n, return the maximum number of different types of candies she can eat if she only eats n / 2 of them.
*/

//Solution 1
public class Solution {
    public int uniqueCandies;
    
    public int DistributeCandies(int[] candyType) {
        // determine the unique number of candies
        // we can use Linq's distinct method to only get the unique elements in the array
        // it returns an IEnumerable so we will use Count to count the items in the returned value
        uniqueCandies = candyType.Distinct().Count();
        
        // she can either eat one of each type or half of the candies, whichever comes first
        return uniqueCandies < candyType.Length/2 ? uniqueCandies : candyType.Length/2;
    }
}

//Solution 2
// this solution comes from leetcode examples of more efficient submissions
public class Solution {
    public int DistributeCandies(int[] candyType) {
        // create a hash set to store items from the candyType array
        // we do this because a HashSet creates a set, which is a collection with no duplicate elements
        HashSet<int> hs = new HashSet<int>();
        
        // loop through the candy types and add them to the hashset
        // if there is already one of the same type in the set it will not be added
        foreach(int type in candyType) {
            hs.Add(type);
        }
        
        // hash set has a count property that will return the number of elements in the set
        return (hs.Count >= candyType.Length/2) ? candyType.Length/2 : hs.Count;
    }
}

/*
Further notes on hashsets from the docs:

1) HashSet<T> automatically increases the capacity as elements are added to the object.
2) HashSet<T> is not sorted and cannot contain duplicate elements, use List<T> if order is needed for application
3) HashSet<T> provides high-performance set opterations similar to accessing the keys of a dictionary
    -> HashSets can be thought of as a dictionary with no values

For more info go to:
https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1?view=net-5.0
*/ 