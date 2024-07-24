namespace IncreasingOrderSearchTree {
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
        public TreeNode IncreasingBST(TreeNode root) {
            List<TreeNode> list = new();

            inorder(root);

            TreeNode newRoot = list[0];
            TreeNode pointer = newRoot;

            //sets newroot as the anchor while pointer is the new node thats just addede to the tree
            for(int i = 1; i < list.Count; i++) {
                pointer.right = list[i];
                pointer.left = null;
                pointer = pointer.right;

            }
            
            pointer.right = null;

            return newRoot;


            void inorder(TreeNode node) {
                if(node == null) return;

                inorder(node.left);
                list.Add(node);
                inorder(node.right);
            }
            
        }


    }
}