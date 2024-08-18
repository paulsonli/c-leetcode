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
            //use inorder traversal to store in a list
            //loop through the list and make the node a right child of the previous and left null
            // make the last child have no children
            List<TreeNode> list = new();

            inorder(root);

            for(int i = 1; i < list.Count; i++) {
                list[i].left = null;
                list[i].right = list[i];
            }

            list[list.Count -1].left = null;
            list[list.Count -1].right = null;

            return list[0];


            void inorder(TreeNode node) {
                if(node == null) return;

                inorder(node.left);
                list.Add(node);
                inorder(node.right);
            }
            
        }


    }
}