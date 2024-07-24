namespace BinaryTreePreOrderTraversal {
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
        public IList<int> PreorderTraversal(TreeNode root) {
            IList<int> results = [];

            Stack<TreeNode> stack = new();
            stack.Push(root);

            while(stack.Count > 0) {
                TreeNode node = stack.Pop();

                //reason for no for loop through stack.count like question 102 is because we are not dealing with levels
                //we just go through the tree inorder so first in first out of stack
                if(node != null) {
                    results.Add(node.val);

                    //it is right then left because of how stack works
                    //last in first out
                    stack.Push(node.right);
                    stack.Push(node.left);
                }
            }

            return results;
        }
    }
}