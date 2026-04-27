//Sqrt(x) (Number #69 on Leetcode)

public class Solution {
    public int MySqrt(int x) {
          if (x < 2)
        return x; //cualquier valor menos 2 no tiene root

    int i = 1;

    //Avoids overflow by dividing by i, maintaining the number below the designated length of int
    while (i <= x / i) 
    {
        i++;
    }

    
    return i - 1; //el loop trabaja hasta que i sea mayor, cual si se pasa, hay que volver al paso anterior para obtener resultado.

    }
}
