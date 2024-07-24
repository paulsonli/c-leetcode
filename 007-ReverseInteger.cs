using System.Globalization;
using System.Xml.XPath;

namespace Reverseinteger {
    public class Solution {
        public int Reverse(int x) {
        
            // int MAX = 2147483647;
            // int MIN = -2147483648;
            
            int MAX = int.MaxValue;
            int MIN = int.MinValue;

            int result = 0;

            while(x != 0) {
                // get the last digit
                int digit = x % 10;
                // divide by 10 to remove last digit
                x /= 10;

                //checks if result is bigger than 214748364 or result is same and incoming digit is greater than 7
                if(result > MAX / 10 || (result == MAX / 10 && digit > MAX % 10)) {
                    return 0;
                }
                // checks if result is smaller than 214748364 or result is same and incoming digit is smaller than -8
                if(result < MIN / 10 || (result == MIN / 10 && digit < MIN % 10)) {
                    return 0;
                }

                //multiply by 10 to move it up a tens place
                result = (result * 10) + digit;
                
            }

            return result;
        }
    }
}