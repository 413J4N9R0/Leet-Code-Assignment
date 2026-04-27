//Palindrome Number (Number #9 on Leetcode)

public class Solution {
    public bool IsPalindrome(int x) {
         if (x < 0){
            return false; //Any negative number is ruled out
        } 

     int og = x;
     int numReversed = 0;

     while (x > 0){

     numReversed = numReversed * 10 + x % 10; // shifts numbers to the left; grabs last digit.
     x /= 10; //removes last digit
     }
      return og == numReversed; //valida
    }
    }
