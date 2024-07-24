namespace AvgLvlInBinaryTree {
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
        public IList<double> AverageOfLevels(TreeNode root) {
            IList<double> avg = [];
            
            Queue<TreeNode> queue = new();
            queue.Enqueue(root);

            while(queue.Count > 0) {
                int queueCount = queue.Count;

                double sumOfLevel = 0;

                for(int i = 0; i < queueCount; i++) {
                    TreeNode node = queue.Dequeue();
                    
                    sumOfLevel += node.val;
                    if(node.left != null) queue.Enqueue(node.left);
                    if(node.right != null)queue.Enqueue(node.right);

                }

                avg.Add(sumOfLevel / queueCount);

            }

            return avg;
        }
    }
}