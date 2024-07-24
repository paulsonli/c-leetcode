namespace ZigzagConversion {
    public class Solution {
        public string Convert(string s, int numRows) {
            if(numRows == 1) return s;

            string results = "";

            // jump by the increment (6) everytime to get the next letter
            for(int row = 0; row < numRows; row++) {
                int increment = (numRows - 1) * 2;
                for(int i = row; i < s.Length; i += increment) {
                    results += s[i];
                    // if it is in middle row, jump 6 to get next letter but then go back 2*row to get middle letters we skipped
                    if(row > 0 && row < numRows - 1 && i + increment - 2 * row < s.Length) {
                        results += s[i + increment - 2 * row];
                    }
                }
            }

            return results;
        }
    }
}