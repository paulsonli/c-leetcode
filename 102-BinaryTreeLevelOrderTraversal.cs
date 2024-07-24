using System.Collections.Generic;

namespace BinaryTreeLevelOrderTraversal {
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
        public IList<IList<int>> LevelOrder(TreeNode root) {
            IList<IList<int>> result = [];

            Queue<TreeNode> queue = new();
            queue.Enqueue(root);

            //.Count gets the length of queue
            //while queue is not empty
            while(queue.Count > 0) {
                //gets the number of nodes in the queue
                int queueLength = queue.Count;
                List<int> level = new();

                //reason it is queueLength and not queue.count is so queuelength doesnt change when
                //adding children to queue
                for(int i = 0; i < queueLength; i++) {
                    //remove the node from queue
                    TreeNode node = queue.Dequeue();
                    if(node != null) {
                        //add value of node to level and then add its children to queue
                        //after it goes through each children, it means it finished with one level
                        level.Add(node.val);
                        queue.Enqueue(node.left);
                        queue.Enqueue(node.right);
                    }
                }

                if(level.Count > 0) result.Add(level);
            }

            return result;
        }
    }
}