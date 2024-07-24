using System.Runtime.Intrinsics;

namespace MergeTwoBinaryTree {
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
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
            if(root1 == null && root2 == null) return null;

            //get value, if only 1 node is null, assign the null as 0 
            int v1 = (root1 != null) ? root1.val : 0;
            int v2 = (root2 != null) ? root2.val : 0;

            TreeNode result = new(v1 + v2)
            {
                // cannot access left or right if node is null; will throw exception
                // "?" returns null if node is null
                left = MergeTrees(root1?.left, root2?.left),
                right = MergeTrees(root1?.right, root2?.right)
            };

            return result;
        }
    }
}