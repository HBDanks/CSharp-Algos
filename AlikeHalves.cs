using System.Linq;

public class Solution {
    // This function determines if both halves of a string contain the same
    // number of vowels and returns a boolean value
    public bool HalvesAreAlike(string s) {
        // Create a hashset for quick lookup of vowels
        HashSet<char> vowels = new HashSet<char>(){
            'a', 'e', 'i', 'o', 'u',
            'A', 'E', 'I', 'O', 'U'
            };
        
        
        string l = s.Substring(0, s.Length/2);
        string r = s.Substring(s.Length/2);

        return l.Count(c => vowels.Contains(c)) == r.Count(c => vowels.Contains(c));
    }
}