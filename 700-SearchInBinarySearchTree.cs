namespace SearchInBinarySearchTree {
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
        public TreeNode SearchBST(TreeNode root, int val) {

            if(root == null || root.val == val) return root;
            //splits the tree in half and only search one side
            //if value is smaller than node, search left, if value is bigger than node search right
            //because binary search tree, left subtree is always smaller than right subtree
            if(root.val > val) {
                return SearchBST(root.left, val);
            }
            else {
                return SearchBST(root.right, val);
            }

        }
    }
}