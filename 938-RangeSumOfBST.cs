namespace RangeSumOfBST {
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
        public int RangeSumBST(TreeNode root, int low, int high) {
            int total = 0;
            void inorder(TreeNode root) {
                    if(root == null) {
                        return;
                    }

                    inorder(root.left);
                    if(root.val >= low && root.val <= high) total += root.val;
                    inorder(root.right);

                }

            inorder(root);
            return total;
        }
    }
}