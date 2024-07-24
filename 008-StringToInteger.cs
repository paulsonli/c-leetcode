using System.Xml.XPath;

namespace StringToInteger{
    public class Solution {
        public int MyAtoi(string s) {

            s = s.TrimStart();
            if(s.Length == 0) return 0;

            int MAX = int.MaxValue;
            int MIN = int.MinValue;
            int result = 0;
            int sign = 1;
            int i = 0;

            if(s[0] == '-') {
                sign = -1;
                i += 1;
            }
            else if(s[0] == '+') {
                i += 1;
            }

            while(i < s.Length) {
                char currenChar = s[i];

                if(!char.IsDigit(currenChar)) break;

                // need to - 0 convert char to int
                int digit = currenChar - '0';
                
                //checks for 32 bit overflow
                if(result * sign > MAX / 10 || (result * sign == MAX / 10 && digit > MAX % 10)) return MAX;
                if(result * sign < MIN / 10 || (result * sign == MIN / 10 && digit < MIN % 10)) return MIN;


                result = result * 10 + digit;

                i++;
            }

            result *= sign;

            return result;
        }
    }
}