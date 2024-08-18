namespace ConvertSortedArrayToBinarySearchTree {
    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution {
        public TreeNode SortedArrayToBST(int[] nums) {
            // have left and right pointer of list and get middle
            // middle will be root and everything on left will be left subtree, everything on right will be right subtree
            // on the left side do the same thing but right pointer is middle - 1
            // on the right side, do same thing but left pointer is middle + 1;

            return helper(0, nums.Length - 1);


            TreeNode helper(int l, int r) {
                if(l > r) return null;

                int m = (l + r) / 2;

                TreeNode root = new() {
                    val = nums[m],
                    left = helper(l, m - 1),
                    right = helper(m + 1, r)
                };

                return root;
            }

        }
    }   
}