namespace EvaluateBooleanBinaryTree {
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
        public bool EvaluateTree(TreeNode root) {
            //full binary tree = 0 or 2 children never 1
            if(root.left == null && root.right == null) {
                return root.val == 1;
            }

            if(root.val == 2) {
                return EvaluateTree(root.left) || EvaluateTree(root.right);
            }

            if(root.val == 3) {
                return EvaluateTree(root.left) && EvaluateTree(root.right);
            }

            return false;
        
        }
    }
}