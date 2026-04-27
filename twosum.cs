public class Solution {
public int[] TwoSum(int[] nums, int targetnum) { //crea arreglo de numeros y assigna un target number
Dictionary<int, int> Nums = new Dictionary<int, int>(); //crea hashmap para GET 0(1); hashmaps (dictionaries) utilizan indice con valor

for (int i = 0; i < nums.Length; i++) //va por los numeros en el diccionario
{
int currentNum = nums[i];
int NumNeeded = targetnum - currentNum; //calcula cuantos hops hasta el numero requerido

if (Nums.ContainsKey(NumNeeded))
{
return new int[] { Nums[NumNeeded], i }; //si lo encuentra, regresa el numero y su indice
}

Nums[currentNum] = i;
}
return new int[] { }; //si no encuentra nada, devuelve un arreglo vacio
}
}
