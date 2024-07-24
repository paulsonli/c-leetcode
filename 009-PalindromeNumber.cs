namespace PalindromeNumber {
    public class Solution {
        public bool isPalindrome(int x) {

            int reversed = 0;
            int copy = x;
            
            //cut the number from the back by mod 10 and add it to reversed then compare
            while(copy > 0) {
                int digit = copy % 10;
                copy /= 10;
                reversed = reversed * 10 + digit;
            }

            return reversed == x;
        }
    }
}