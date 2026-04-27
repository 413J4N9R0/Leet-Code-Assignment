public class Solution {
public int[] TwoSum(int[] nums, int targetnum) {
Dictionary<int, int> Nums = new Dictionary<int, int>();

for (int i = 0; i < nums.Length; i++)
{
int currentNum = nums[i];
int NumNeeded = targetnum - currentNum;

if (Nums.ContainsKey(NumNeeded))
{
return new int[] { Nums[NumNeeded], i };
}

Nums[currentNum] = i;
}

return new int[] { };
}
}
