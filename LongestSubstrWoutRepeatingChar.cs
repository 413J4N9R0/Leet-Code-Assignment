//Longest substring without repeating any characters (Number #3 on Leetcode)

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> substr = new HashSet<char>(); //se crea un hashset para evitar duplicados 0(1) en todo aspecto (worse case ps 0(n)
    int left = 0, maxLength = 0;

    for (int right = 0; right < s.Length; right++)//mueve el puntero a la derecha
    {
        while (substr.Contains(s[right]))
        {
            substr.Remove(s[left]);//si encuentra duplicado, se remueve de la izquierda y continua hasta que no hayaa duplicados.
            left++;
        }

        substr.Add(s[right]);// continua añadiendo al substring
        maxLength = Math.Max(maxLength, right - left + 1);//mantener en cuenta/actualiza  el largo antes/despues de cambios por duplicados
    }

    return maxLength;//resultado 
    }
}
