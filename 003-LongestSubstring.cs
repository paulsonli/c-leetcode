using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace LongestSubstring {
    public class Solution {
        public int LengthOfLongestSubstring(string s) {
            //using 2 pointer system "sliding window"
            HashSet<char> charset = new();
            int lpointer = 0;
            int count = 0;

            for(int rpointer = 0; rpointer < s.Length; rpointer++) {
                //while s[rpointer] is in charset aka has dups, remove lpointer from set and move it up one slot in the string
                while(charset.Contains(s[rpointer])) {
                    charset.Remove(s[lpointer]);
                    lpointer++;
                }
                //once all dups are gone from set, add rpointer to set
                charset.Add(s[rpointer]);
                // check if current substring is longer pervious
                count = Math.Max(count, rpointer - lpointer + 1);
            }

            return count;
            
        }

    }
    
}