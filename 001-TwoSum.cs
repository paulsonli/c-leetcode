namespace TwoSums{
    public class Solution {

        public int[] TwoSum(int[] nums, int target) {
            for(int i = 0; i < nums.Length; i++) {
                for(int j = i + 1; j < nums.Length; j++){
                    if(nums[i] + nums[j] == target) {
                        return [i, j];
                    }
                }
            }
            throw new ArgumentException("None");
        }

        //goes through each number in the list and check if any of the numbers after it adds up to the target

        public static void main(string[] args) {
            int[] myList = [3,3];
            int target = 6;

            Solution solution = new Solution();

            int[] results = solution.TwoSum(myList, target);

            //Console.WriteLine($"{results[0]}, {results[1]}");
        }


    }
    

}
