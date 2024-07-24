namespace UnquieBinarySearchTree {
    public class Solution {
        public int NumTrees(int n) {    
            int[] numTree = new int[n + 1];

            numTree[0] = 1;
            numTree[1] = 1;

            for(int nodes = 2; nodes <= n; nodes++) {
                int total = 0;
                for(int root = 1; root <= nodes; root++) {
                    int left = root - 1;  //ex. 3 is root, left side only has 1 , 2 aka 3 - 1
                    int right = nodes - root;

                    total += numTree[left] * numTree[right];

                }

                numTree[nodes] = total;
            }

            return numTree[n];
        }
    }
}