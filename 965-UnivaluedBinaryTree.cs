using MaxDepthOfNaryTree;

namespace UnivaluedBinaryTree {
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
        public bool IsUnivalTree(TreeNode root) {

            return helper(root);

            bool helper(TreeNode node) {
                if(node == null) return true;

                if(node.val != root.val) return false;

                return helper(node.left) && helper(node.right);
            }

            // Queue<TreeNode> queue = new();
            // queue.Enqueue(root);

            // while(queue.Count > 0) {
            //     TreeNode node = queue.Dequeue();

            //     //only need for loop if levels are important;

            //     if(node.val != root.val) return false;

            //     if(node.left != null) queue.Enqueue(node.left);
            //     if(node.right != null) queue.Enqueue(node.right);
            // }

            // return true;
        }
    }

}