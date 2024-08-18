namespace DeepestLeavesSum {
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
        public int DeepestLeavesSum(TreeNode root) {
            //instead of a list storing sum of every level, only store the sum of the current level
            //saves memory space
            int sum = 0;
            Queue<TreeNode> queue = new();

            queue.Enqueue(root);

            while(queue.Count > 0) {
                int queueCount = queue.Count;
                sum = 0;

                for(int i = 0; i < queueCount; i++) {
                    TreeNode node = queue.Dequeue();

                    sum += node.val;

                    if(node.left != null) queue.Enqueue(node.left);
                    if(node.right != null) queue.Enqueue(node.right);
                }

            }

            return sum;
        }
    }
}