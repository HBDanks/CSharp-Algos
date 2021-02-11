public class Solution {
    // for first solve I used a dictionary
    private Dictionary<char, int> characters = new Dictionary<char,int>();
    
    // for second solve I used an array

    private int[] count = new int[26];

    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        
        for(int i = 0; i < s.Length; i++)
        {
            if(!characters.ContainsKey(s[i]))
            {
                characters.Add(s[i], 1);
            }
            else
            {
                characters[s[i]] += 1;
            }
        }
        
        for(int i = 0; i < t.Length; i++)
        {
            if(!characters.ContainsKey(t[i]))
            {
                return false;
            }
            characters[t[i]] -= 1;
            if(characters[t[i]] < 0)
            {
                return false;
            }
        }
        
        for(int i = 0; i < s.Length; i++)
        {
            if(characters[s[i]] != 0)
            {
                return false;
            }
        }
        
        return true;
    }

    // in this method we will take advantage of ascii values and use them as indices in our array
    public bool IsAnagram(string s, string t)
    {
        // first we check to see if the strings are not the same length
        // if they are not then they can not be anagrams
        if (s.Length != t.Length) 
        {
            return false;
        }

        // Next we will loop through the strings
        // we will add to the value in count for each character in s
        // and subtract from count for each character in t
        for (int i = 0; i < s.Length; i++)
        {
            // by subtracting 'a' we make our indexes 0 based for lowercase letters
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }
        
        // now we loop through the count array
        // we opt for the count array because we know this will only be of length 26
        // while the strings are length n
        // 
        foreach (int i in count)
        {
            // if the value in count is not 0
            // we know the count for that character in string s and string t was not equal
            // therefore we return false
            if (i != 0) return false;
        }
        // if all the characters were the same, we return true
        return true;
    }
}