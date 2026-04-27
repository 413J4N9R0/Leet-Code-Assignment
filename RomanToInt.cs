public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> Nums = new Dictionary<char, int>() //diccionario con los valores entre cada letra romana
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    int total = 0;

    for (int i = 0; i < s.Length; i++)
    {
        int currentLetter = Nums[s[i]]; //busca los valores por letra 

        if (i < s.Length - 1 && currentLetter < Nums[s[i + 1]])
        {
            total -= currentLetter; // busca si el valor izquierdo es menor, cual requiere que reste 
        }
        else
        {
            total += currentLetter; //else, just add
        }
    }

    return total;
    }
}
