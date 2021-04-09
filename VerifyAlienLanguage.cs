public class Solution {
    /**
     * * IsAlienSorted determines if an series of words is written in an
     * * alien language using their given alphabet "order"
     * 
     * @params string words
     * @params string order
     * @return bool
     */
    public bool IsAlienSorted(string[] words, string order) {
        Dictionary<char, int> Alphabet = new Dictionary<char, int>();
        int counter = 0;
        
        foreach(char l in order)
        {
            Alphabet.Add(l, counter);
            counter++;
        }
        
        int i = 0;
        while( i < words.Length - 1 )
        {
            int j = 0;
            while( j < words[i].Length )
            {
                if(j == words[i+1].Length || Alphabet[words[i+1][j]] - Alphabet[words[i][j]] < 0)
                {
                    return false;
                }
                else if(Alphabet[words[i+1][j]] - Alphabet[words[i][j]] > 0)
                {
                    break;
                }
                
                j++;
            }
            i++;
        }
        
        return true;
    }
}