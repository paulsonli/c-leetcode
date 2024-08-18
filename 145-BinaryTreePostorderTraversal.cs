namespace BinaryTreePostorderTraversal {
    public class TreeNode {
        public int val;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null) {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution {
    public IList<int> PostorderTraversal(TreeNode root) {
        IList<int> results = [];

        post(root);
        
        return results;

        void post(TreeNode node) {
            if(node == null) return;

            post(node.left);
            post(node.right);
            results.Add(node.val);
        }

    }
}
}