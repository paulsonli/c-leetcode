namespace LongestPalindromicSubstring {
    public class Solution {
        public string LongestPalindrome(string s) {
            string result = "";
            int resultLength = 0;

            //go through each letter as the center of a palindrome. check left and right char if they are same, if so keep expanding.
            for(int center = 0; center < s.Length; center++) {
                //check odd length
                int lpointer = center;
                int rpointer = center;

                //can write a function
                while(lpointer > 0 && rpointer < s.Length && s[lpointer] == s[rpointer]) {
                    if(rpointer - lpointer + 1 > resultLength) {
                        resultLength = rpointer - lpointer + 1;
                        result = s.Substring(lpointer, resultLength);
                    }
                    lpointer -= 1;
                    rpointer += 1;
                }   

                // check even length
                //instead of having one letter as center, we have 2 letters as center
                lpointer = center;
                rpointer = center + 1;

                while(lpointer > 0 && rpointer < s.Length && s[lpointer] == s[rpointer]) {
                if(rpointer - lpointer + 1 > resultLength) {
                    resultLength = rpointer - lpointer + 1;
                    result = s.Substring(lpointer, resultLength);
                }
                lpointer -= 1;
                rpointer += 1;
            }
            }

            return result;
        }

        // public void checkPalindrome(int lpointer, int rpointer, string s, ref string result, ref int resultLength) {
        //     while(lpointer > 0 && rpointer < s.Length && s[lpointer] == s[rpointer]) {
        //         if(rpointer - lpointer + 1 > resultLength) {
        //             resultLength = rpointer - lpointer + 1;
        //             result = s.Substring(lpointer, resultLength);
        //         }
        //         lpointer -= 1;
        //         rpointer += 1;
        //     }
        // }

    }

}